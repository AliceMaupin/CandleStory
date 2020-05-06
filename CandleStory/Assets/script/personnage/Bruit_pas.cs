using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruit_pas : MonoBehaviour
{
    public AudioClip Terre, Interieur, Os, corbeaux ,curSound;

    public float volMin;
    public float VolMax;
    public float pitchMin;
    public float pitchMax;
    private float runcoef = 2;


    AudioSource audioS;


    void Start()
    {

        audioS = GetComponent<AudioSource>();
    }



    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {

            case "Terre":
                curSound = Terre;
                break;
            case "Interieur":
                curSound = Interieur;
                break;
            case "Os":
                curSound = Os;
                break;
            case "corbeaux":
                curSound = corbeaux;
                break;
        }

        Debug.Log("detectepas");
    }


    private void OnTriggerExit(Collider other)
    {

       
        curSound = null;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (!audioS.isPlaying)
            {
                audioS.volume = Random.Range(volMin, VolMax);
                audioS.pitch = Random.Range(volMin, VolMax);
                audioS.PlayOneShot(curSound);


                if (Input.GetKey(KeyCode.LeftShift))
                {
                    audioS.pitch *= runcoef;
                }
            }
        }

    }





}
