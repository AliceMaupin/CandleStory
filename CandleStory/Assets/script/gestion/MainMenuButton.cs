using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuButton : MonoBehaviour
{
    public GameObject mainMenuUI;

    public GameObject optionsUI;
    public void Options()
    {
        mainMenuUI.SetActive(false);
        optionsUI.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SplashScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
