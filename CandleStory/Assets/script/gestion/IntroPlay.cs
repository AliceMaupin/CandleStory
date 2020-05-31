using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroPlay : MonoBehaviour
{
    public GameObject loadingScreen;

    public void Intro()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene("SplashScreen");
    }
}
