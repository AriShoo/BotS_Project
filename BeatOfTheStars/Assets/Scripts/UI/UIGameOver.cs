using RhythmGameStarter;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    public StatsSystem Stats;

    [SerializeField] Button _menuButton;

    void Start()
    {
        _menuButton.onClick.AddListener(MainMenu);
    }

    private void MainMenu()
    {
        Debug.Log("Go to Main Menu");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.MainMenu);
    }

    private void HighScore()
    {
        string scoreKey = "Score";
        Stats.score = PlayerPrefs.GetInt(scoreKey);


        Debug.Log("Save highscore");
        
        
        

        //ScenesManager.instance.LoadScene(ScenesManager.Scene.HighScores);
    }

}
