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
        // Aquí puedes agregar lógica específica para diferentes tags
        switch (tag)
        {
            case "Player":
                // Lógica para cuando el jugador toma daño
                currentHealth -= damage;
                Debug.Log("El jugador ha recibido " + damage + " puntos de daño.");
                break;

            case "Enemy":
                // Lógica para cuando el enemigo toma daño
                currentHealth -= damage;
                Debug.Log("El enemigo ha recibido " + damage + " puntos de daño.");
                break;

            default:
                // Lógica para otros tags o caso por defecto
                currentHealth -= damage;
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
        // Puedes agregar aquí lógica para la muerte, como desactivar el objeto
        Destroy(gameObject);
    }
}
