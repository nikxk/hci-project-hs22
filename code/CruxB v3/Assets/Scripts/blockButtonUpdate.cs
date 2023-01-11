using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class blockButtonUpdate : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button> ().onClick.AddListener(() => Controller.ChangeState(Int32.Parse(this.name.Substring(5,1))));
    }
}
