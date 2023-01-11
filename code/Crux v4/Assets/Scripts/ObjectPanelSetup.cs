using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectPanelSetup : LeftpanelParent
{
    void Awake()
    {
        items = Data.objectNames;
        datatype = "object";
        setupPanel();
    }
}