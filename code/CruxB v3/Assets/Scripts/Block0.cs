using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Block0 : MonoBehaviour
{
    private static string frame = "Block0";

    void Start()
    {
        //frame = this.gameObject;
    }

    public static bool Validate()
    {
        bool flag = true;
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1", "leftBlank", "A.speed_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "AssignFrame 1", "equals", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1", "rightBlank", "3_button_child");
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (1)", "leftBlank", "A.rate_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "AssignFrame 1 (1)", "equals", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (1)", "rightBlank", "3_button_child");
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (2)", "leftBlank", "A.time_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "AssignFrame 1 (2)", "equals", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (2)", "rightBlank", "0_button_child");
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (3)", "leftBlank", "M.speed_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "AssignFrame 1 (3)", "equals", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (3)", "rightBlank", "10_button_child");
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (4)", "leftBlank", "score_button_child");
        flag &= ValidationHelper.ValidateDropDown(frame, "AssignFrame 1 (4)", "equals", 0);
        flag &= ValidationHelper.ValidateBlank(frame, "AssignFrame 1 (4)", "rightBlank", "0_button_child");
        return flag;
    }
}
