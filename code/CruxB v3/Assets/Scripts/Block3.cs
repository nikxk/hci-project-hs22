using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Block3 : MonoBehaviour
{
    private static string frame = "Block3";

    void Start()
    {
        //frame = this.gameObject;
    }

    public static bool Validate()
    {
        bool flag = true;
        //if
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame", "condBlank1", "A.time_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame", "operator", 1);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame", "condBlank2", "A.rate_button_child");
        //blank
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame", "Blank", "spawn()_button_child", "Asteroid_button_child");
        //assign
        flag &= ValidationHelper.ValidateNestedBlank(frame, "IfFrame", "AssignFrame 1", "leftBlank", "A.time_button_child");
        flag &= ValidationHelper.ValidateNestedDropDown(frame, "IfFrame", "AssignFrame 1", "equals", 0);
        flag &= ValidationHelper.ValidateNestedBlank(frame, "IfFrame", "AssignFrame 1", "rightBlank", "0_button_child");
        return flag;
    }
}

