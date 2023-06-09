using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreLetterEntry : MonoBehaviour
{
    [SerializeField] public Image Letter1;
    [SerializeField] public Image Letter2;
    [SerializeField] public Image Letter3;

    public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    private int index;
    public string currentLetter;
    Text letter = GameObject.Find("letter").GetComponent<Text>();


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            index++;
            if (index >= alpha.Length)
                index = 0; // loop

            // set text to letter
            letter.text = alpha[index].ToString();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            index--;
            if (index <= alpha.Length)
                index = 0; // loop

            // set text to letter
            letter.text = alpha[index].ToString();
        }


    }
}
