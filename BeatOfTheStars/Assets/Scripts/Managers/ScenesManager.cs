using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance;

    public static bool visible;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Cursor.visible = false;
    }

    public enum Scene
    {
        SplashScreen,
        MainMenu,
        Tutorial,
        Level1,
        Level2,
        Level3,
        Credits,
        HighScores,
        GameOver
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Level1.ToString());
    }

    public void LoadNextScene () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(Scene.GameOver.ToString());
    }

    public void LoadHighScore()
    {
        SceneManager.LoadScene(Scene.HighScores.ToString());
    }

    public void LoadSplash()
    {
        SceneManager.LoadScene(Scene.SplashScreen.ToString());   
    }

    public void LoadCredits ()
    {
        SceneManager.LoadScene(Scene.Credits.ToString());
    }

    public void Quit()
    {
        Application.Quit();
    }
}
