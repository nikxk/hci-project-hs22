using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    public static int state = 0;

    public static List<GameObject> blanks = new List<GameObject>();

    public static void ChangeState(int newState)
    {
        state = newState;

        // change active button
        var buttons = GameObject.Find("Rightpanel").GetComponentsInChildren<Button>();
        string openButtonName = "Block" + state.ToString() + "button";
        foreach (var button in buttons)
        {
            if (button.name == openButtonName)
                button.interactable = false;
            else
                button.interactable = true;
        }

        var title = GameObject.Find("EditBlockTitle");
        title.GetComponentInChildren<TMP_Text>().text = "<b>"+Data.blockNames[state]+"</b> block";

        // change active block
        var par = GameObject.Find("Controller").transform;
        for(int idx=0; idx<Data.blockNames.Count; idx++)
        {
            string blockName = "Block"+idx.ToString();
            if (idx == state)
            {
                par.Find(blockName).gameObject.SetActive(true);
            }
            else
            {
                par.Find(blockName).gameObject.SetActive(false);
            }
        }

    }

    public static void recordBlank(GameObject blank)
    {
        blanks.Add(blank);
    }

    public static void removeBlank(GameObject blank)
    {
        blanks.Remove(blank);
    }

    public static int inBlank(Vector3 position)
    {
        if (blanks.Count == 0)
        {
            return -1;
        }

        var blankRev = new List<GameObject>(blanks);
        blankRev.Reverse();

        // check if position is in any of the blanks, if yes return blank
        foreach (var blank in blankRev)
        {
            if (blank.GetComponent<BlankS>().isIn(position))
            {
                return blanks.IndexOf(blank);
            }
        }

        return -1;
    }

    // public GameObject funcBlankPrefab;
    // [SerializeField]
    // private GameObject blockPrefab;
    // [SerializeField]
    // private GameObject ifFramePrefab;
    // [SerializeField]
    // private GameObject assignFramePrefab;

    // void Awake()
    // {
    //     // create blocks
    //     for (int i = 0; i < Data.blockNames.Count; i++)
    //     {
    //         // create block and set parent
    //         var block = Instantiate(blockPrefab, this.transform);
    //         block.name = "Block" + i.ToString();
    //         // set block inactive
    //         block.SetActive(false);
    //         // fill block with skeletal statements
    //         var content = Data.blockContent[i] as ArrayList;
    //         // render block content
    //         Vector2 cursor = new Vector2(20, -20);
    //         for (int i = 0; i < content.Count; i++)
    //         {
    //             var statementType = content[i,0] as string;

    //             switch (statementType)
    //             {
    //                 case "asn":
    //                     var statement = Instantiate(assignFramePrefab, block.transform);
    //                     // set the position of statement
    //                     statement.GetComponent<RectTransform>().anchoredPosition = cursor;
    //                     var assignContent = content[i,1] as ArrayList;
    //                     var assignLeft = assignContent[0] as ArrayList;
    //                     var assignOperator = assignContent[1] as string;
    //                     var assignRight = assignContent[2] as ArrayList;
    //                     // render left

    //                     break;
    //                 default:
    //                 Debug.Log("Error: statement type not recognized");
    //             }
    //             // create statement

    //             var statementObject = Instantiate(blockPrefab, block.transform);
    //         }
    //     }        

    // }
    
    public int nClicks = 0;

    void Start()
    {
        ChangeState(0);
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            nClicks++;
            Debug.Log("Clicks: " + nClicks);
        }
    }
}
