using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class nameInput : MonoBehaviour
{
    public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    [SerializeField] private TextMeshProUGUI _letter01;
    [SerializeField] private TextMeshProUGUI _letter02;
    [SerializeField] private TextMeshProUGUI _letter03;

    private int currIndex = 0;
    public void UpArrow()
    {
        currIndex++;
        if (currIndex >= alpha.Length)
            currIndex = 0; // Loop around
        // Set Text to new Letter
        _letter01.text = alpha[currIndex].ToString();
        _letter02.text = alpha[currIndex].ToString();
        _letter03.text = alpha[currIndex].ToString();
    }
}
