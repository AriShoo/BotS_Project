using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreLetterEntry : MonoBehaviour
{
    public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    private int index;
    public string currentLetter;


    private void Update()
    {
        TextMeshProUGUI letter = GameObject.Find("letter").GetComponent<TextMeshProUGUI>();

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            index++;
            if (index >= alpha.Length)
                index = 0; // loop

            // set text to letter
            letter.text = alpha[index].ToString();
            Debug.Log(letter.text);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            index--;
            if (index < 0)
                index = alpha.Length - 1; // loop

            // set text to letter
            letter.text = alpha[index].ToString();
            Debug.Log(letter.text);
        }

        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            letter.text = currentLetter;
        }

        
    }
}
