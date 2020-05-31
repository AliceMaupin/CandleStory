using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuButton : MonoBehaviour
{
    public GameObject mainMenuUI;

    public GameObject optionsUI;

    public GameObject loadingScreen;
    public void Options()
    {
        mainMenuUI.SetActive(false);
        optionsUI.SetActive(true);
    }

    public void Validate()
    {
        mainMenuUI.SetActive(true);
        optionsUI.SetActive(false);
    }

    public void StartGame()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene("Intro");   
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
