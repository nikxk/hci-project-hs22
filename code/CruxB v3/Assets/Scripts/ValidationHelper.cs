using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValidationHelper : MonoBehaviour
{
    private static Transform controller = null;
    void Start()
    {
        controller = this.gameObject.transform;
    }
    public static bool ValidateBlank(string frameName, string frameName0, string blankName, string blockName)
    {
        GameObject block = controller.Find(frameName).Find(frameName0).Find(blankName).GetComponent<BlankS>().getOccupant();
        if (block == null || block.name != blockName)
        {
            return false;
        }
        return true;
    }

    public static bool ValidateNestedBlank(string frameName, string frameName0, string frameName1, string blankName, string blockName)
    {
        //GameObject frame = GameObject.Find(frameName);
        GameObject block = controller.Find(frameName).Find(frameName0).Find(frameName1).Find(blankName).GetComponent<BlankS>().getOccupant();
        if (block == null || block.name != blockName)
        {
            return false;
        }
        return true;
    }

    public static bool ValidateFunction(string frameName, string blankName, string blockName0, string blockName1)
    {
        //GameObject frame = GameObject.Find(frameName);
        //Transform blank = controller.Find(frameName).Find(blankName);
        //if (blank == null) return false;
        GameObject block = controller.Find(frameName).Find(blankName).GetComponent<BlankS>().getOccupant();
        if (block == null || block.name != blockName0)
        {
            return false;
        }
        block = controller.Find(frameName).Find(blankName).Find(blockName0).Find("functionBlank(Clone)").GetComponent<BlankS>().getOccupant();
        //replace this if statement
        if (block == null)
        {
            if (blockName1 == null) return true;
            return false;
        }
        if (block.name == blockName1)
        {
            return true;
        }
        return false;
    }

    public static bool ValidateNestedFunction(string frameName, string frameName0, string frameName1, string blockName0, string blockName1)
    {
        //GameObject frame = GameObject.Find(frameName);
        //Transform blank = controller.Find(frameName).Find(frameName0).Find(frameName1);
        //if (blank == null) return false;
        GameObject block = controller.Find(frameName).Find(frameName0).Find(frameName1).GetComponent<BlankS>().getOccupant();
        if (block == null || block.name != blockName0)
        {
            return false;
        }
        block = controller.Find(frameName).Find(frameName0).Find(frameName1).Find(blockName0).Find("functionBlank(Clone)").GetComponent<BlankS>().getOccupant();
        //replace this if statement
        if (block == null)
        {
            if (blockName1 == null) return true;
            return false;
        }
        if (block.name == blockName1)
        {
            return true;
        }
        return false;
    }

    public static bool ValidateDropDown(string frameName, string frameName0, string dropDownName, int value)
    {
        //GameObject frame = GameObject.Find(frameName);
        return controller.Find(frameName).Find(frameName0).Find(dropDownName).GetComponent<TMPro.TMP_Dropdown>().value == value ? true : false;
    }

    public static bool ValidateNestedDropDown(string frameName, string frameName0, string frameName1, string dropDownName, int value)
    {
        //GameObject frame = GameObject.Find(frameName);
        return controller.Find(frameName).Find(frameName0).Find(frameName1).Find(dropDownName).GetComponent<TMPro.TMP_Dropdown>().value == value ? true : false;
    }
}
