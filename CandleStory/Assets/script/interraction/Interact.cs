using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;

    private bool hasPlayer = false;


    protected Vector3 postLastFame;
    public Camera UIcam;



    void Update()
    {
        // check distance entre objet et joueur
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        // si - ou = 1.9 unitÃ©s de distance = on peut interagir
        if (dist <= 5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        // si on peut interagir et qu'on appuie sur E = on intéragit avec l'objet
        if (hasPlayer && Input.GetKey(KeyCode.E))
        {
            if(gameObject.CompareTag("LetterC"))
            {
                GameManager.firstLetterComa = true;
            }

            if (gameObject.CompareTag("LetterO") && GameManager.firstLetterComa == true)
            {
                GameManager.secondLetterComa = true;
            }
            else
            {
                GameManager.firstLetterComa = false;
            }

            if (gameObject.CompareTag("LetterM") && GameManager.secondLetterComa == true)
            {
                GameManager.thirdLetterComa = true;
            }
            else
            {
                GameManager.firstLetterComa = false;
                GameManager.secondLetterComa = false;
            }

            if (gameObject.CompareTag("LetterA") && GameManager.thirdLetterComa == true)
            {
                GameManager.coma = true;
            }
            else
            {
                GameManager.firstLetterComa = false;
                GameManager.secondLetterComa = false;
                GameManager.thirdLetterComa = false;
            }
        }

        // Si on porte l'objet



    }
}
