using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ErrorMsg : MonoBehaviour
{
    //public TextMeshProUGUI outText;
    [SerializeField] public TextMeshProUGUI outText;
    public void Display(string input)
    {
        outText.text = input;
    }
}