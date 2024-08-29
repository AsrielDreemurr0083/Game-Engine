using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class RuleManager : MonoBehaviour
{
    [SerializeField] Text[] buttonTexts;
    [SerializeField] string[] buttonTextNames;


    void Start()
    {
        for (int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = buttonTextNames[i];
        }

    }


    void Update()
    {

    }

    public void Blue()
    {
        Debug.Log("Blue Card");
    }
    public void Green()
    {
        Debug.Log("Green Card");
    }
    public void Yellow()
    {
        Debug.Log("Yellow Card");
    }
    public void Purple()
    {
        Debug.Log("Purple Card");
    }
    public void Gray()
    {
        Debug.Log("Gray Card");
    }

    public void Blue2()
    {
        Debug.Log("Blue Card");
    }
    public void Green2()
    {
        Debug.Log("Green Card");
    }
    public void Yellow2()
    {
        Debug.Log("Yellow Card");
    }
    public void Purple2()
    {
        Debug.Log("Purple Card");
    }
    public void Gray2()
    {
        Debug.Log("Gray Card");
    }
}
