using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreLetterEntry : MonoBehaviour
{
    ScoreEntryManager scoreEntryManager;

    public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    private int index;

    [HideInInspector]
    public string currentLetter;


    private void Update()
    {
        TextMeshProUGUI letter = transform.Find("letter").GetComponent<TextMeshProUGUI>();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index++;
            if (index >= alpha.Length)
                index = 0; // loop

            // set text to letter
            letter.text = alpha[index].ToString();

            currentLetter = letter.text;
            Debug.Log(letter.text);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index--;
            if (index < 0)
                index = alpha.Length - 1; // loop

            // set text to letter
            letter.text = alpha[index].ToString();

            currentLetter = letter.text;
            Debug.Log(letter.text);
        }

        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            currentLetter = letter.text;
            Debug.Log("Submit button pressed");
        }

    }
}
