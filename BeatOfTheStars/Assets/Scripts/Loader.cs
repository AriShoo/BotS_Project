using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public enum Scene
    {
        IntroVideo, SplashScreen, MainMenu, 
        Tutorial, Level1, Level2, Level3, 
        HighScores, Credits, Loading
    }

    private static Action onLoaderCallback;

    public static void Load(Scene scene)
    {
        // This sets loader callback action to load target scene
        onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        // Load loading scene
        SceneManager.LoadScene(Scene.Loading.ToString());

    }

    public static void LoaderCallback()
    { 
        // Triggers after first update which lets screen refresh
        // Execute the loader callback action which loads target scene
        if (onLoaderCallback != null) 
            onLoaderCallback(); 
            onLoaderCallback = null;
    }
}
