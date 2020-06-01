using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lever : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;

    public Animator animator;

    private bool hasPlayer = false;

    public static bool activatedLever = false;

    public GameObject grid;

    protected Vector3 postLastFame;
    public Camera UIcam;

    public GameObject UI;

    public bool check = false;

    // Update is called once per frame
    void Update()
    {
        // check distance entre objet et joueur
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        // si - ou = 1.9 unitÃ©s de distance = on peut interagir
        if (dist <= 2f)
        {
            if ( check == false)
            {
                UI.SetActive(true);
            }
            
            hasPlayer = true;
            
        }
        else
        {
            UI.SetActive(false);
            hasPlayer = false;
        }

        if (hasPlayer && Input.GetKey(KeyCode.E))
        {
            check = true;

            UI.SetActive(false);
            activatedLever = true;
            animator.SetBool("activatedLever", true);
        }
    }
}
