using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprinter : MonoBehaviour
{

    public float stamina = 5, maxStamina = 5;

    public float coolDownTime = 1f;
    private float nextRUN = 0f;

    float walkSpeed, runSpeed;
    CharacterMotor cm;
    public bool isRunning;

    public AudioClip essouflement;

    private AudioSource esouflé;



    // visuel bar stamina
    Rect staminaRect;
    Texture2D staminaTexture;

    void Start()
    {
        // on vient chercher le script charactermotor
        cm = gameObject.GetComponent<CharacterMotor>();
        walkSpeed = cm.movement.maxForwardSpeed;
        runSpeed = walkSpeed * 4;

        //parametre visuel staminaBar
        staminaRect = new Rect(Screen.width / 10, Screen.height * 9 / 10, // position
            Screen.width / 3, Screen.height / 50);
        staminaTexture = new Texture2D(1, 1);
        staminaTexture.SetPixel(0, 0, Color.white); // couleur
        staminaTexture.Apply(); // on l'applique

        esouflé = GetComponent<AudioSource>();

    }

    void SetRunning(bool isRunning)
    {
        this.isRunning = isRunning;

        cm.movement.maxForwardSpeed = isRunning ? runSpeed : walkSpeed;
    }


    void Update()
    {
        // quand on appuie on sprint, quand on relache on marche
        if (Input.GetKeyDown(KeyCode.LeftShift))
            SetRunning(true);
        if (Input.GetKeyUp(KeyCode.LeftShift))
            SetRunning(false);

        // quand on court la stamina diminue et quand elle passe à 0, on marche
        if (isRunning)
        {

            stamina -= Time.deltaTime;
            if (stamina <= 0)
            {
                esouflé.PlayOneShot(essouflement);
                stamina = 0;
                SetRunning(false);

                nextRUN = Time.time + coolDownTime;
            }
        }
        else if (Time.time > nextRUN)
        {
            if ((stamina < maxStamina))
            {
                stamina += Time.deltaTime;


            }

        }

        void OnGUI()
        {
            float ratio = stamina / maxStamina;
            float rectWidth = ratio * Screen.width / 3;
            staminaRect.width = rectWidth;
            GUI.DrawTexture(staminaRect, staminaTexture);
        }




    }



}


