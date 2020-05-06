using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSonCorbeaux : MonoBehaviour
{
   

    private void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Croa Croa je suis le corbeau qui fait peur");
        }
    }

    private void Update()
    {
        
    }
}
