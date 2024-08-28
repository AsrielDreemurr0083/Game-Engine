using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] ScoreUI scoreUI;
    void Awake()
    {
        Load();
    }

    public void IncreaseScore()
    {
        
        int random = Random.Range(5, 11);
        score += random;

        scoreUI.OnUpdate(random);
        PlayerPrefs.SetInt("Score", score);

    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");

    }

    //public void Save()
    //{
    //    PlayerPrefs.Save();
    //}
    //
    //private void Update()
    //{   
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //    PlayerPrefs.DeleteAll();               
    //    }
    //    Load();    
    //}

    public void Initialized()
    {
        PlayerPrefs.DeleteAll();
        Load();
    }

}
