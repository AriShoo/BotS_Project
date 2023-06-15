using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    [SerializeField] Button toLevel;
    [SerializeField] Button Quit;
    [SerializeField] Button Credits;
    [HideInInspector]

    ScenesManager scenesManager;


    void Start()
    {
        toLevel.onClick.AddListener(PlayGame);
        Quit.onClick.AddListener(QuitGame);
        Credits.onClick.AddListener(LoadCredits);
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

    private void LoadCredits()
    {
        if (Input.GetKey(KeyCode.Keypad7))
        {
            Debug.Log("Load credits");
            ScenesManager.instance.LoadScene(ScenesManager.Scene.Credits);
        }
    }

}
