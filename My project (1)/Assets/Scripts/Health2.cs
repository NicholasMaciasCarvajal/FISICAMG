using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health2 : MonoBehaviour
{
    public int maxHealth;  // 3 corazones * 2 de vida cada uno
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage, string tag)
    {
        switch (tag)
        {
            case "Player":
                currentHealth -= damage;
                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
                Debug.Log("El jugador ha recibido " + damage + " puntos de daño.");
                break;

            case "enemigo":
                currentHealth -= damage;
                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
                Debug.Log("El enemigo ha recibido " + damage + " puntos de daño.");
                break;

            default:
                currentHealth -= damage;
                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
                Debug.Log("Un objeto ha recibido " + damage + " puntos de daño.");
                break;
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " ha muerto.");
        // Lógica para la muerte, como desactivar el objeto
        Destroy(gameObject);
    }
}
