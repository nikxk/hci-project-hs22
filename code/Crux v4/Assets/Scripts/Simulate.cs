using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Simulate : MonoBehaviour
{
    private string errortext = "";
    [SerializeField] public GameObject textField;
    [SerializeField] public GameObject errorPanel;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => Validate());
    }

    void Validate()
    {
        errortext = "";
        if (!Block0.Validate()) AddText("Initialize"); //Debug.Log("Your input for Block 0 is wrong!");
        if (!Block1.Validate()) AddText("Handle Input");; //Debug.Log("Your input for Block 1 is wrong!");
        if (!Block2.Validate()) AddText("Update Position");; //Debug.Log("Your input for Block 2 is wrong!");
        if (!Block3.Validate()) AddText("Spawn Asteroid");; //Debug.Log("Your input for Block 3 is wrong!");
        if (!Block4.Validate()) AddText("Collision Check");; //Debug.Log("Your input for Block 4 is wrong!");

        // Debug.Log("All validation done.");
         //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if(errortext == "")
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }else
        {
            //send Errortext to error panel text 2 and activate error Panel
            textField.GetComponent<ErrorMsg>().Display(errortext);
            errorPanel.SetActive(true);
        }
    }

    private void AddText(string msg)
    {
        if(errortext == "") errortext = msg;
        else if(errortext != "") errortext = errortext + ", "+ msg;
    }
}
