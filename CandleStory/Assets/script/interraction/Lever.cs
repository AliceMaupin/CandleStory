using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;


    private bool hasPlayer = false;

    public GameObject grid;

    protected Vector3 postLastFame;
    public Camera UIcam;

    // Update is called once per frame
    void Update()
    {
        // check distance entre objet et joueur
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        // si - ou = 1.9 unitÃ©s de distance = on peut interagir
        if (dist <= 2f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        if (hasPlayer && Input.GetKey(KeyCode.E))
        {
            grid.SetActive(false);
        }
    }
}
