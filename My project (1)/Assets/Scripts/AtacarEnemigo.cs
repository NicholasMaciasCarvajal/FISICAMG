using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacarEnemigo : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed;
    public float launchInterval;
    public float lifetime; // Tiempo de vida en segundos

    private float timeSinceLastLaunch;

    void Update()
    {
        // Lanzar proyectil automáticamente cada 'launchInterval' segundos
        timeSinceLastLaunch += Time.deltaTime;
        if (timeSinceLastLaunch >= launchInterval)
        {
            LaunchProjectile();
            timeSinceLastLaunch = 0;
        }
    }

    void LaunchProjectile()
    {
        // Crear el proyectil en la posición y con la rotación del objeto actual (objeto madre)
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

        // Obtener la dirección en la que está mirando el objeto madre
        Vector3 direction = transform.right;

        // Asignar velocidad al proyectil en la dirección calculada
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction * projectileSpeed;
        }
        else
        {
            Debug.LogWarning("El proyectil no tiene un Rigidbody2D.");
        }

        // Iniciar la corrutina para destruir el proyectil después del tiempo especificado
        StartCoroutine(DestroyAfterTime(projectile, lifetime));
    }

    IEnumerator DestroyAfterTime(GameObject projectile, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(projectile);
    }
}
