using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupOnWalk : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameManager.hasKeyA = true;
        Destroy(gameObject);
    }
}
