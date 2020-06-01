using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupOnWalk : MonoBehaviour
{
    public GameObject GrabUI;

    public static bool HaveKey;
    // Start is called before the first frame update
    void Start()
    {

    }




    
    void Update()
    {

    }
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

        CheckListPerso.clés1 = true;

        Debug.Log(CheckListPerso.clés1);
       
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
