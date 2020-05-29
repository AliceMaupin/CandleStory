using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool hasKeyA = false;

    public GameObject keyAUI;

    public static Vector3 CheckpointPosition;

    public static GameManager s_Singleton;

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public static bool firstLetterComa = false;
    public static bool secondLetterComa = false;
    public static bool thirdLetterComa = false;
    public static bool coma = false;

    public static bool firstLetterMarc = false;
    public static bool secondLetterMarc = false;
    public static bool thirdLetterMarc = false;
    public static bool marc = false;


    private void Awake()
    {
        if (s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
