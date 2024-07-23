using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Atacar : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed;
    public float launchInterval;
    public float lifetime; // Tiempo de vida en segundos

    private float timeSinceLastLaunch;

    void Update()
    {
        // Lanzar proyectil con una tecla (por ejemplo, la tecla espacio)
        if (Input.GetKeyDown(KeyCode.E))
        {
            LaunchProjectile();
        }

        // Lanzar proyectil con el bot�n izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            LaunchProjectile();
        }

        // Lanzar proyectil autom�ticamente cada 'launchInterval' segundos
        timeSinceLastLaunch += Time.deltaTime;
        if (timeSinceLastLaunch >= launchInterval)
        {
            LaunchProjectile();
            timeSinceLastLaunch = 0;
        }
    }

    void LaunchProjectile()
    {
        // Crear el proyectil en la posici�n y con la rotaci�n del objeto actual (objeto madre)
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

        // Obtener la direcci�n en la que est� mirando el objeto madre
        Vector3 direction = transform.right; 

        // Asignar velocidad al proyectil en la direcci�n calculada
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction * projectileSpeed;
        }
        else
        {
            Debug.LogWarning("El proyectil no tiene un Rigidbody2D.");
        }

        // Iniciar la corrutina para destruir el proyectil despu�s del tiempo especificado
        StartCoroutine(DestroyAfterTime(projectile, lifetime));
    }

    IEnumerator DestroyAfterTime(GameObject projectile, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(projectile);
    }

}
