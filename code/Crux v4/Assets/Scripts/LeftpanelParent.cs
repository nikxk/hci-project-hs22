using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeftpanelParent : MonoBehaviour
{
    public Button buttonPrefab;

    protected List<string> items;
    protected string datatype = "";

    protected void setupPanel()
    {
        float height = this.GetComponent<RectTransform>().rect.height;
        float width = this.GetComponent<RectTransform>().rect.width;

        int row = 0;
        float used_width = 50f;
        float text_offset = 20f;
        float button_offset = 10f;

        for (int i = 0; i < items.Count; i++)
        {
            // Create a new button, name it
            var button = Instantiate(buttonPrefab, this.transform);
            button.name = items[i] + "_button";
            button.GetComponentInChildren<TMP_Text>().text = items[i];
            button.GetComponentInChildren<TMP_Text>().ForceMeshUpdate();            
            
            // Get the text width and set button width accordingly
            float text_width = button.GetComponentInChildren<TMP_Text>().GetRenderedValues(true).x;
            button.GetComponent<RectTransform>().sizeDelta = new Vector2(text_offset + text_width, button.GetComponent<RectTransform>().rect.height);
            button.GetComponent<BoxCollider2D>().size = new Vector2(text_offset + text_width, button.GetComponent<RectTransform>().rect.height);

            // set datatype of parent to bricktype of button
            button.GetComponent<Draggable>().bricktype = datatype;

            // Set the button position
            if (used_width + text_width + text_offset> width)
            {
                row++;
                used_width = 50f;

                if (used_width + text_width + text_offset > width || row > 3)
                {
                    Debug.Log("Exceeds display space for "+this.transform.name);
                    return;
                }
            }

            button.transform.localPosition = new Vector3(-width/2.0f + used_width + text_width/2.0f, height/2.0f - 65 - row * 50, 0);

            used_width += text_width + text_offset + button_offset;
        }
    }
}
