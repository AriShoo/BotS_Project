using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISplashMenu : MonoBehaviour
{
    [SerializeField] Button _anyButton;

    void Start()
    {
        _anyButton.onClick.AddListener(AnyButton);
    }

    private void AnyButton()
    {
        Debug.Log("Go to Main Menu");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.MainMenu);
    }
}
