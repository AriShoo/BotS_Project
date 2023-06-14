using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILevel1 : MonoBehaviour
{
    [SerializeField] Button _continue;
    [SerializeField] Button _quit;

    ScenesManager ScenesManager;

    void Start()
    {
        _continue.onClick.AddListener(Continue);
        _quit.onClick.AddListener(QuitGame);

    }

    private void Continue()
    {
        ScenesManager.LoadNextScene();
    }

    private void QuitGame()
    {
        ScenesManager.LoadGameOver();
    }


}
