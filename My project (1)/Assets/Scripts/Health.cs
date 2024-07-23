using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth ;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage, string tag)
    {
        // Aqu� puedes agregar l�gica espec�fica para diferentes tags
        switch (tag)
        {
            case "Player":
                // L�gica para cuando el jugador toma da�o
                currentHealth -= damage;
                Debug.Log("El jugador ha recibido " + damage + " puntos de da�o.");
                break;

            case "Enemy":
                // L�gica para cuando el enemigo toma da�o
                currentHealth -= damage;
                Debug.Log("El enemigo ha recibido " + damage + " puntos de da�o.");
                break;

            default:
                // L�gica para otros tags o caso por defecto
                currentHealth -= damage;
                Debug.Log("Un objeto ha recibido " + damage + " puntos de da�o.");
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
        // Puedes agregar aqu� l�gica para la muerte, como desactivar el objeto
        Destroy(gameObject);
    }
}
