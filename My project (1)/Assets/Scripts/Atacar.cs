using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    /*private PrefabInstanceStatus Ataque;

    // Start is called before the first frame update
    void Start()
    {
                foreach (GameObject obj in objectsToDestroy)
        {
            StartCoroutine(DestroyAfterTime(obj, lifetime));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void A�a�ar()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
        }
    }*/

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
        // Crear el proyectil en la posici�n del objeto actual
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Obtener la posici�n del mouse en el mundo
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Asegurarse de que la posici�n Z sea 0 (o la misma que el objeto lanzador si es necesario)

        // Calcular la direcci�n desde el objeto hacia el mouse
        Vector3 direction = (mousePosition - transform.position).normalized;

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
