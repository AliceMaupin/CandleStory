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
    }
}
