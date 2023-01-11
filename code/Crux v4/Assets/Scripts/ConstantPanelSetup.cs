using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConstantPanelSetup : LeftpanelParent
{
    void Awake()
    {
        items = Data.constantNames;
        datatype = "constant";
        setupPanel();
    }
}