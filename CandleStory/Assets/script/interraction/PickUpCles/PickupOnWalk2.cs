using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupOnWalk2 : MonoBehaviour
{


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
        CheckListPerso.clés2 = true;

        Debug.Log(CheckListPerso.clés1);

    }


}
