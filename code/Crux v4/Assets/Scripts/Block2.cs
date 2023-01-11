using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Block2 : MonoBehaviour
{
    private static string frame = "Block2";

    void Start()
    {
        //frame = this.gameObject;
    }

    public static bool Validate()
    {
        bool flag = true;
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1", "leftBlank", "A.time_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "AssignFrame 1", "equals", 1);
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1", "rightBlank", "0.1_button_child");
        flag &= ValidationHelper.ValidateFunction(frame, "Blank", "update()_button_child", "Missile_button_child");
        flag &= ValidationHelper.ValidateFunction(frame, "Blank (1)", "update()_button_child", "Asteroid_button_child");
        return flag;
    }
}
