using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeToGame()
    {
        SceneManager.LoadSceneAsync("Game Scene", LoadSceneMode.Single);
    }
    
    public void ChangeToMenu()
    {
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
    }
    
    public void ChangeToText()
    {
        SceneManager.LoadSceneAsync("IntroText", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    }