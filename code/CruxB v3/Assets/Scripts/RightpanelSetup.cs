using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RightpanelSetup : MonoBehaviour
{
    public Button buttonPrefab;
    public GameObject arrowPrefab;
    public GameObject loopblockPrefab;

    private List<string> items = new List<string>();

    void Awake()
    {
        items = Data.blockNames;
        setPanel();
    }

    private void setPanel()
    {        
        float height = this.GetComponent<RectTransform>().rect.height;
        float width = this.GetComponent<RectTransform>().rect.width;
        float buttonHeight = buttonPrefab.GetComponent<RectTransform>().rect.height;
        float buttonWidth = buttonPrefab.GetComponent<RectTransform>().rect.width;

        int nButtons = items.Count;
        float offset = 20f;

        loopblockPrefab = Instantiate(loopblockPrefab, this.transform);
        loopblockPrefab.GetComponent<RectTransform>().sizeDelta = new Vector2(buttonWidth+10f, (nButtons-1)*(buttonHeight+offset));
        loopblockPrefab.transform.localScale = new Vector3(buttonWidth+10f, (nButtons-1)*(buttonHeight+offset)-offset/2.0f, 1.0f);
        loopblockPrefab.transform.localPosition = new Vector3(width/2.0f - buttonWidth/2.0f - 5f, height/2.0f - 0.5f*offset - 0.5f*(1+nButtons)*(buttonHeight + offset) , 0);

        for (int i = 0; i < nButtons; i++)
        {
            var button = Instantiate(buttonPrefab, this.transform);
            button.transform.localPosition = new Vector3(width/2.0f-buttonWidth/2.0f, height/2.0f -buttonHeight/2.0f - offset -i * (buttonHeight+offset), 0);

            button.name = "Block"+ i.ToString() + "button";
            button.GetComponentInChildren<TMP_Text>().text = items[i];

            if (i != nButtons - 1)
            {
                var arrow = Instantiate(arrowPrefab, this.transform);
                arrow.name = "Arrowhead" + i.ToString();
                arrow.transform.localPosition = new Vector3(width/2.0f-buttonWidth/2.0f, height/2.0f - buttonHeight/2.0f - offset -(i + 0.5f) * (buttonHeight+offset), 0);
            }
        }
    }
}
