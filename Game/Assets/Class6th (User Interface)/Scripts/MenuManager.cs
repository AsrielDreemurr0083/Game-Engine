using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    //[SerializeField] Text buttonText;
    //[SerializeField] Text buttonText2;
    //[SerializeField] Text buttonText3;
    [SerializeField] Text[] buttonTexts;
    [SerializeField] string[] buttonTextNames;

    void Start()
    {
        // [ ] = "New Game"

        //buttonTextNames[0] = "New Game";
        //buttonTextNames[1] = "Continue";
        //buttonTextNames[2] = "Exit";
        //
        //buttonText.text = buttonTextNames[0];
        //buttonText2.text = buttonTextNames[1];
        //buttonText3.text = buttonTextNames[2];

        for (int i = 0; i < buttonTextNames.Length; i++)
        {
            buttonTexts[i].text = buttonTextNames[i];
        }
        



    }

    void Update()
    {
        
    }

    public void NewGame()
    {
        Debug.Log("New Game");
    }
    public void Continue()
    {
        Debug.Log("Continue");
    }
    public void Exit()
    {
        Debug.Log("Exit");
    }
}
