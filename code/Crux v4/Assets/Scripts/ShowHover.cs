using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ShowHover : MonoBehaviour
{
    public GameObject hintPanel;
    public static Action OnHover;
    public static Action NoHover;

    void Start()
    {
        HideHint();
    }
    private void OnEnable()
    {
       OnHover += ShowHint;
       NoHover += HideHint; 
    }
    private void OnDisable()
    {
       OnHover -= ShowHint;
       NoHover -= HideHint; 
    }

    private void ShowHint()
    {
       hintPanel.SetActive(true);
    }
    private void HideHint()
    {
        hintPanel.SetActive(false);
    }
}
