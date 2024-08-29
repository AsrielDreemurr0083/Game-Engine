using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    [SerializeField] Text TimeText;

    float time = 60f;
    private void Awake()
    {
        TimeText = GetComponent<Text>();
    }

    public void Update()
    {
        Timer();
    }


    public void Timer()
    {
        time -= Time.deltaTime;
        TimeText.text = Mathf.Ceil(time).ToString();
        if (time < 0)
        {
            Debug.Log("Time Out");
            time = 0;
        }
    }
}
