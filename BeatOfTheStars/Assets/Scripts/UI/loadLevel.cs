using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    [SerializeField] Button toLevel;
    [SerializeField] Button Quit;
    [HideInInspector]

    ScenesManager scenesManager;


    void Start()
    {
        toLevel.onClick.AddListener(PlayGame);
        Quit.onClick.AddListener(QuitGame);
    }
    private void PlayGame()
    {
        if (Input.GetKey(KeyCode.Keypad7))
        {
            Debug.Log("Play level 1");
            ScenesManager.instance.LoadScene(ScenesManager.Scene.Level1);
        }
    }

    private void QuitGame()
    {
        if (Input.GetKey(KeyCode.Keypad7))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }

}
