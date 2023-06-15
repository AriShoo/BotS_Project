using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadText : MonoBehaviour
{
    public GameObject TextObj;
    public GameObject ReturnMenu;
    float TmStart;
    float TmLen = 29f;

    // Use this for initialization
    void Start()
    {
        TmStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TmStart + TmLen)
        {

            TextObj.SetActive(true);
            ReturnMenu.SetActive(true);
        }
    }
}
