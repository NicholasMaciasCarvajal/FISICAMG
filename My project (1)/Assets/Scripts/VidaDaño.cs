using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDaño : MonoBehaviour
{
    /*
    
    public int vida; // Vida inicial del enemigo
    public int daño; // Daño que inflige el proyectil

    public void TomarDaño(int cantidad)
    {
        vida -= daño;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "proyectil")
        {
            if (other.tag == "enemigo")
            {
                VidaDaño enemigo = other.GetComponent<VidaDaño>();
                if (enemigo != null)
                {
                    enemigo.TomarDaño(daño);
                }
            }
        }
    }

    
    private void OnTriggerEnter2D(BoxCollider2D collision)
    {
        if (gameObject.CompareTag("proyectil"))
        {
            // Verificar si el objeto con el que colisiona tiene el tag "enemigo"
            if (collision.CompareTag("enemigo"))
            {
                // Intentar obtener el componente 'DañoManager' del objeto colisionado
                VidaDaño enemigo = collision.GetComponent<VidaDaño>();
                if (enemigo != null)
                {
                    // Hacer daño al enemigo
                    enemigo.TomarDaño(daño);

                    // Destruir el proyectil después de colisionar
                    Destroy(gameObject);
                }
            }
        }
    }

    public void TomarDaño(int daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    */
}