using RhythmGameStarter;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIGameOver : MonoBehaviour
{
    //public StatsSystem Stats;

    [SerializeField] Button _continue;

    void Start()
    {
        
    }

    public void SelectGameOver()
    {
        EventSystem.current.SetSelectedGameObject(_continue.gameObject);
    }
    public void GameFinished()
    {

        if (Input.GetKey(KeyCode.Keypad7))
        {
            Debug.Log("Load Game over screen");
            ScenesManager.instance.LoadScene(ScenesManager.Scene.GameOver);
        }

    }


   /* private void MainMenu()
    {
        Debug.Log("Go to Main Menu");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.MainMenu);
    }*/

   /* private void HighScore()
    {
        string scoreKey = "Score";
        Stats.score = PlayerPrefs.GetInt(scoreKey);


        Debug.Log("Save highscore");
        
        
        

        //ScenesManager.instance.LoadScene(ScenesManager.Scene.HighScores);
    }*/

}
