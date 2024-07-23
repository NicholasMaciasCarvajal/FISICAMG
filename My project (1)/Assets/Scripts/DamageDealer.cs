using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount; // Cantidad de daño que inflige el prefab

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto con el que colisiona tiene el componente Health
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null)
        {
            // Infligir daño basado en el tag del objeto con el que colisiona
            health.TakeDamage(damageAmount, collision.gameObject.tag);
        }

        // Destruir el prefab después de infligir daño, opcional
        Destroy(gameObject);
    }
}
