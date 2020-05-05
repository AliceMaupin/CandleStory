using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool hasKeyA = false;

    public GameObject keyAUI;

    public static Vector3 CheckpointPosition;

    public static GameManager s_Singleton;

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
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(CheckpointPosition);
        if(hasKeyA == true)
        {
            keyAUI.SetActive(true);
        }
        
        if(hasKeyA == false)
        {
            keyAUI.SetActive(false);
        }*/
        DontDestroyOnLoad(gameObject);
    }

}
