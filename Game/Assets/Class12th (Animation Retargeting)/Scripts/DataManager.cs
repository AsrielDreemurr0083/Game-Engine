using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] int score1;
    void Awake()
    {
        Load();
    }

    public void IncreaseScore()
    {
        score += 10;
        score1 += Random.Range(5, 10);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Score1", score1);
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
        score1 = PlayerPrefs.GetInt("Score1");

    }

    public void Save()
    {
        PlayerPrefs.Save();
    }

    private void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
        PlayerPrefs.DeleteAll();               
        }
        Load();    
    }

}
