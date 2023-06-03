using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _playGame;
    [SerializeField] Button _tutorial;
    [SerializeField] Button _highScores;
    [SerializeField] Button _credits;
    [SerializeField] Button _quit;

    void Start()
    {
        _playGame.onClick.AddListener(PlayGame);
        _tutorial.onClick.AddListener(Tutorial);
        _highScores.onClick.AddListener(HighScores);
        _credits.onClick.AddListener(Credits);
        _quit.onClick.AddListener(Quit);
    }

    private void PlayGame()
    {
        Debug.Log("Play level 1");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.Level1);
    }
    private void Tutorial()
    {
        Debug.Log("Load tutorial");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.Tutorial);
    }

    private void HighScores()
    {
        Debug.Log("Load High scores");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.HighScores);
    }

    private void Credits()
    {
        Debug.Log("Load credits");
        ScenesManager.instance.LoadScene(ScenesManager.Scene.Credits);
    }

    private void Quit()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
