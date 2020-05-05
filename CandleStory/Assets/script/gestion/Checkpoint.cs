using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static bool checkpointReached = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("sheikhpoint");
            checkpointReached = true;
            GameManager.CheckpointPosition = gameObject.transform.position;
        }
    }
}
