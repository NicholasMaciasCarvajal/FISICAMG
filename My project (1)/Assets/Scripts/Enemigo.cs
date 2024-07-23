using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vida; // Vida inicial del enemigo

    public void TomarDa�o(int da�o)
    {
        vida -= da�o;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
