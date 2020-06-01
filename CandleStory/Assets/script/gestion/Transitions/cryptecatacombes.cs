using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cryptecatacombes : MonoBehaviour
{
    public GameObject loadingScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loadingScreen.SetActive(true);
            SceneManager.LoadScene("Catacombes");
        }
    }
}