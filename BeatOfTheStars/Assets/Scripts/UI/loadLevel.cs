using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    [SerializeField] Button toLevel;
    [HideInInspector]

    ScenesManager scenesManager;
    

    void Start()
    {
        toLevel.onClick.AddListener(PlayGame);
    }
    private void PlayGame()
    {
        if (Input.GetKey(KeyCode.Keypad7))
        {
            Debug.Log("Play level 3");
            ScenesManager.instance.LoadScene(ScenesManager.Scene.Level3);
        }
    }

}
