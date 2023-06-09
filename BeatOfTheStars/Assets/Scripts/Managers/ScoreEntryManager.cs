using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;
using RhythmGameStarter;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreEntryManager : MonoBehaviour
{
    public StatsSystem Stats;
    public scoreLetterEntry scoreLetterEntry;
    public highScoreTable highScoreTable;

    [SerializeField] public scoreLetterEntry Letter1;
    [SerializeField] public scoreLetterEntry Letter2;
    [SerializeField] public scoreLetterEntry Letter3;

    private void Start()
    {
        GameObject _Letter1 = GameObject.Find("_Letter1");
        GameObject _Letter2 = GameObject.Find("_Letter2");
        GameObject _Letter3 = GameObject.Find("_Letter3");

        int score = 123456;
       // int score = Stats.score;
        string name;
        int order;
        order = 0;

        _Letter1.SetActive(true);
        _Letter2.SetActive(false);
        _Letter3.SetActive(false);

        name = Letter1.currentLetter + Letter2.currentLetter + Letter3.currentLetter;

        switch (order)
        {
            default:
                _Letter1.SetActive(true);
                _Letter2.SetActive(false);
                _Letter3.SetActive(false); break;
            case 1:
                if (Input.GetKeyUp(KeyCode.Keypad7))
                _Letter1.SetActive(false);
                _Letter2.SetActive(true);
                _Letter3.SetActive(false); break;
            case 2:
                if (Input.GetKeyUp(KeyCode.Keypad7))
                _Letter1.SetActive(false);
                _Letter2.SetActive(false);
                _Letter3.SetActive(true); break;
            case 3:
                if (Input.GetKeyUp(KeyCode.Keypad7))
                _Letter1.SetActive(false);
                _Letter2.SetActive(false);
                _Letter3.SetActive(false); break;

        }



    } 

}

