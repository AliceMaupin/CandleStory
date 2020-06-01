using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cimetierecrypte : MonoBehaviour
{
    public GameObject loadingScreen;

    public static bool endLevel = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loadingScreen.SetActive(true);
            endLevel = true;
            SceneManager.LoadScene("crypte");
        }
    }
}
