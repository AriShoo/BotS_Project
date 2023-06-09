using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using RhythmGameStarter;
using UnityEngine.EventSystems;
using System.Linq;

public class ScoreEntryManager : MonoBehaviour
{
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

    public int letterSelected;
    int score = 123456;

    private void Update()
    {
        GameObject _Letter1 = GameObject.Find("_Letter1"); // 0
        GameObject _Letter2 = GameObject.Find("_Letter2"); // 1
        GameObject _Letter3 = GameObject.Find("_Letter3"); // 2
        GameObject Buttons = GameObject.Find("Buttons");



        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            letterSelected++;
            if (letterSelected > 2) eventSystem.SetSelectedGameObject(GameObject.Find("Buttons"));
        }

        



        string name = Letter1.currentLetter + Letter2.currentLetter + Letter3.currentLetter;
    }

  

    /* switch (order)
     {
         case 1:
             if (Input.GetKeyUp(KeyCode.Keypad7))
             _Letter1.SetActive(true);
             _Letter2.SetActive(false);
             _Letter3.SetActive(false); break;
         case 2:
             if (Input.GetKeyUp(KeyCode.Keypad7))
             _Letter1.SetActive(false);
             _Letter2.SetActive(true);
             _Letter3.SetActive(false); break;
         case 3:
             if (Input.GetKeyUp(KeyCode.Keypad7))
             _Letter1.SetActive(false);
             _Letter2.SetActive(false);
             _Letter3.SetActive(true); break;

     }*/



} 

