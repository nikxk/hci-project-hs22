using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Block4 : MonoBehaviour
{
    private static string frame = "Block4";

    void Start()
    {
    }

    public static bool Validate()
    {
        bool flag = true;
        //if
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame", "condBlank1", "A.collide()_button_child", "Missile_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame", "operator", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame", "condBlank2", "true_button_child");
        //blank
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame", "Blank", "despawn()_button_child", "Missile_button_child");
        //blank (1)
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame", "Blank (1)", "despawn()_button_child", "Asteroid_button_child");
        //assign
        flag &= ValidationHelper.ValidateNestedBlank(frame, "IfFrame", "AssignFrame 1", "leftBlank", "score_button_child");
        flag &= ValidationHelper.ValidateNestedDropDown(frame, "IfFrame", "AssignFrame 1", "equals", 1);
        flag &= ValidationHelper.ValidateNestedBlank(frame, "IfFrame", "AssignFrame 1", "rightBlank", "1_button_child");
        //if (1)
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (1)", "condBlank1", "A.collide()_button_child", "Rocket_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame (1)", "operator", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame (1)", "condBlank2", "true_button_child");
        //add following line:
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (1)", "Blank", "END()_button_child", null);
        //if (2)
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (2)", "condBlank1", "A.collide()_button_child", "Ground_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "IfFrame (2)", "operator", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "IfFrame (2)", "condBlank2", "true_button_child");
        //add following line:
        flag &= ValidationHelper.ValidateNestedFunction(frame, "IfFrame (2)", "Blank", "END()_button_child", null);
        return flag;
    }
}

