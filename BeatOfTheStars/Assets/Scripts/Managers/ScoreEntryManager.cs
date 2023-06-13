using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using RhythmGameStarter;
using UnityEngine.EventSystems;
using System.Linq;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class ScoreEntryManager : MonoBehaviour
{
    [HideInInspector]
    StatsSystem Stats;
   
    EventSystem eventSystem;

    [SerializeField] public scoreLetterEntry[] Letters;
    int letterIndex = 0;
    

    private void Start()
    {
        
    }


    private void Update()
    {
        GameObject Buttons = GameObject.Find("Buttons");



        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            Letters[letterIndex].enabled = false;
            letterIndex++;
            if(letterIndex > Letters.Length)
            {
                UpdateHighScore();
                ScenesManager.instance.LoadHighScore();
            }
            else
            {
                Letters[letterIndex].enabled = true;
            }
        }

    }

    private void UpdateHighScore()
    {

        string name = Letters[0].currentLetter + Letters[1].currentLetter + Letters[2].currentLetter;

        string scoreKey = "Score";
        int score = PlayerPrefs.GetInt(scoreKey);

        highScoreTable.AddHighScoreEntry(score, name);

    }
    


} 

