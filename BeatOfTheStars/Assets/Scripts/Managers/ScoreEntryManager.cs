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
    scoreLetterEntry scoreLetterEntry;
    highScoreTable highScoreTable;
    EventSystem eventSystem;

    [SerializeField] public scoreLetterEntry Letter1;
    [SerializeField] public scoreLetterEntry Letter2;
    [SerializeField] public scoreLetterEntry Letter3;
    

    private void Start()
    {
        
    }


    private void Update()
    {
        GameObject _Letter1 = GameObject.Find("_Letter1"); // 0
        GameObject _Letter2 = GameObject.Find("_Letter2"); // 1
        GameObject _Letter3 = GameObject.Find("_Letter3"); // 2
        GameObject Buttons = GameObject.Find("Buttons");

        

    }

    private void UpdateHighScore()
    {
        Letter1.currentLetter = scoreLetterEntry.currentLetter;
        Letter2.currentLetter = scoreLetterEntry.currentLetter;
        Letter3.currentLetter = scoreLetterEntry.currentLetter;

        string name = Letter1.currentLetter + Letter2.currentLetter + Letter3.currentLetter;

        string scoreKey = "Score";
        int score = PlayerPrefs.GetInt(scoreKey);

        highScoreTable.AddHighScoreEntry(score, name);

    }
    


} 

