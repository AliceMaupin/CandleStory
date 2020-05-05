using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Turn : MonoBehaviour
{
    public float movespeed = 10f;
    public float turnspeed = 50f;


    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.forward * movespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(-Vector3.forward * movespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
