using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grille : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (Lever.activatedLever == true)
        {
            animator.SetBool("activatedLever", true);
        }

        if(cimetierecrypte.endLevel == true)
        {
            Lever.activatedLever = false;
            cimetierecrypte.endLevel = false;
        }

        if(cryptecatacombes.endLevel == true)
        {
            Lever.activatedLever = false;
            cryptecatacombes.endLevel = false;
        }
    }
}
