using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupOnWalk6 : MonoBehaviour
{
    public GameObject GrabUI;

    public static bool HaveKey;





    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {

            HaveKey = true;
            Destroy(gameObject);
        }
    }



    private void OnDestroy()
    {
        GrabUI.SetActive(false);

        CheckListPerso.clés6 = true;

        Debug.Log(CheckListPerso.clés6);

    }


    private void OnTriggerEnter(Collider other)
    {
        GrabUI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        GrabUI.SetActive(false);
    }

}
