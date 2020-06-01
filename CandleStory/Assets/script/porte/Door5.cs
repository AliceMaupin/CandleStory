using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door5 : MonoBehaviour
{

    public Animator anim;

    public GameObject UI;

    public bool porte = false;


    void Start()
    {

        UI.SetActive(false);
        porte = false;
        anim = GetComponent<Animator>();
    }


    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {
        if (CheckListPerso.clés5 == true && Input.GetKeyDown(KeyCode.E) && other.tag == "Player")
        {
            UI.SetActive(false);
            porte = true;
            anim.SetBool("Keyn1", true);


        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (porte == false)
        {
            UI.SetActive(true);
        }

    }


    private void OnTriggerExit(Collider other)
    {
        UI.SetActive(false);
    }

}
