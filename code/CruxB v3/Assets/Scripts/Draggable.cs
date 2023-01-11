using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Draggable : MonoBehaviour
{
    private Camera _cam;
    private Vector3 _dragOffset;
    private bool isChild = false; // is the object a child of a block?

    public GameObject blank = null; // the blank in the object (if function)

    public string bricktype = "";
    public GameObject funcBlankPrefab = null;

    void Awake()
    {
        // set size of collider to the size of button
        this.GetComponent<BoxCollider2D>().size = this.GetComponent<RectTransform>().sizeDelta;

        _cam = Camera.main;
    }

    void OnMouseDown()
    {
        // get the offset of the mouse click from the center of the button
        _dragOffset = this.transform.position - GetMousePosition();

        if(isChild)
        {
            // remove occupant from parent blank
            this.transform.parent.GetComponent<BlankS>().removeOccupant();
        }
        else
        {
            // create a copy of parent button and make this a child
            var copy = Instantiate(this.gameObject, this.transform.parent);
            string name = this.name;
            this.name = name + "_child";
            copy.name = name;
            this.isChild = true;
        }
    }

    void OnMouseDrag()
    {
        // set position to mouse position with offset
        this.transform.position = GetMousePosition() + _dragOffset;
    }

    Vector3 GetMousePosition()
    {
        // convert mouse position to world position
        Vector3 worldPosition = _cam.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0;
        return worldPosition;
    }

    void OnMouseUp()
    {
        // check if the button is in a blank space
        int inBlank = Controller.inBlank(GetMousePosition());
        if (inBlank != -1)
        {
            var blank = Controller.blanks[inBlank].GetComponent<BlankS>();
            if(blank.blanktype == this.bricktype || blank.blanktype == "")
            {
                if (!blank.isFree())
                    blank.killOccupant();
                blank.addOccupant(this.gameObject);
            }
            else
            {
                if (this.bricktype == "function" && this.blank != null)
                    Controller.removeBlank(this.blank);
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (this.bricktype == "function" && this.blank != null)
                Controller.removeBlank(this.blank);
            Destroy(this.gameObject);
        }
    }

    public void addBlank()
    {
        // add a blank to the function
        this.blank = Instantiate(this.funcBlankPrefab, this.transform);
        blank.transform.localPosition = new Vector3(0, 0, 0);

        // remove last character from TMP text
        string text = this.GetComponentInChildren<TMP_Text>().text;
        text = text.Substring(0, text.Length - 1);
        this.GetComponentInChildren<TMP_Text>().text = text;
        this.GetComponentInChildren<TMP_Text>().ForceMeshUpdate();

        float text_width = this.GetComponentInChildren<TMP_Text>().GetRenderedValues(true).x;
        float blank_width = blank.GetComponent<RectTransform>().sizeDelta.x;

        // set blanktype corresponding to the function
        var funcNames = Data.functionNames;
        if(this.name.StartsWith(funcNames[5]))
        {
            blank.GetComponent<BlankS>().blanktype = "constant";
        }
        else if(this.name.StartsWith(funcNames[0]) || this.name.StartsWith(funcNames[6]))
        {
            blank.GetComponent<BlankS>().blanktype = "";
        }
        else
        {
            blank.GetComponent<BlankS>().blanktype = "object";
        }

        // enlarge button to fit text
        float width = 5 + text_width + blank_width + 10;
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(width, 37);
        this.GetComponent<BoxCollider2D>().size = new Vector2(width, 37);

        // position the text and blank
        this.GetComponentInChildren<TMP_Text>().transform.localPosition = new Vector3(-width/2.0f+5+ text_width / 2.0f, 0, 0);
        blank.transform.localPosition = new Vector3(-width/2 + 5 + text_width + blank_width/2.0f, 0, 0);
        
        // create new TMP text with ")" and add to button
        var new_text = Instantiate(this.GetComponentInChildren<TMP_Text>(), this.transform);
        new_text.text = ")";
        new_text.GetComponent<RectTransform>().sizeDelta = new Vector2(5, 38);
        new_text.transform.localPosition = new Vector3(-width/2.0f+5+text_width+blank_width+new_text.GetComponent<RectTransform>().sizeDelta.x/2.0f, 0, 0);
    }
}
