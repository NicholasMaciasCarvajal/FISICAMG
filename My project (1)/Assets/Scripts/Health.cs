using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 6;  // 3 corazones * 2 de vida cada uno
    private int currentHealth;
    [SerializeField] UIManager uIManager;

    void Start()
    {
        currentHealth = maxHealth;
        uIManager.ActualizarCorazones(currentHealth);
    }

    public void TakeDamage(int damage, string tag)
    {
        switch (tag)
        {
            case "Player":
                currentHealth -= damage;
                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
                uIManager.ActualizarCorazones(currentHealth);
                Debug.Log("El jugador ha recibido " + damage + " puntos de da�o.");
                break;

            case "Enemy":
                currentHealth -= damage;
                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
                Debug.Log("El enemigo ha recibido " + damage + " puntos de da�o.");
                break;

            default:
                currentHealth -= damage;
                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
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
        // L�gica para la muerte, como desactivar el objeto
        Destroy(gameObject);
    }
}
