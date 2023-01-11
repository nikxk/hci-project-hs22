using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FunctionPanelSetup : LeftpanelParent
{
    void Awake()
    {   
        items = Data.functionNames;
        datatype = "function";

        for (int i = 0; i < items.Count; i++)
            items[i] = items[i] + "()";

        setupPanel();
    }
}