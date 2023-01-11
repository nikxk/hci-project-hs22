using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Block1 : MonoBehaviour
{
    private static string frame = "Block1";
    void Start()
    {
    }

    public static bool Validate()
    {
        bool flag = true;
        //if frame
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame", "condBlank1", "input()_button_child", null);
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame", "operator", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame", "condBlank2", "<_button_child");
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame", "Blank", "R.move()_button_child", "left_button_child");
        //if frame (1)
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (1)", "condBlank1", "input()_button_child", null);
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame (1)", "operator", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame (1)", "condBlank2", ">_button_child");
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (1)", "Blank", "R.move()_button_child", "right_button_child");
        //if frame (2)
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (2)", "condBlank1", "input()_button_child", null);
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame (2)", "operator", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame (2)", "condBlank2", "space_button_child");
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (2)", "Blank", "spawn()_button_child", "Missile_button_child");
        return flag;
    }
}
