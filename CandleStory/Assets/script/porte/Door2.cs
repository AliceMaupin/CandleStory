using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{

    public Animator anim;



    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {
        if (CheckListPerso.clés2 == true && Input.GetKeyDown(KeyCode.E) && other.tag == "Player")
        {

            anim.SetBool("Keyn1", true);


        }

    }


}