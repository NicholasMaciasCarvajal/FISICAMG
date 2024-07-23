using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vida; // Vida inicial del enemigo

    public void TomarDaño(int daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
