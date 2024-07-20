using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Obtener el componente Animator del objeto
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("Izquierda");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.Play("Derecha");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("Arriba");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("Abajo");
        }
    }
}
