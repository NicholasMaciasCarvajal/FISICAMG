using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    public Transform positionA; // Primera posición
    public Transform positionB; // Segunda posición

    public float moveSpeed = 2.0f; // Velocidad de movimiento

    void Start()
    {
        // Iniciar la corrutina de movimiento constante
        StartCoroutine(MoveBetweenPositions());
    }

    IEnumerator MoveBetweenPositions()
    {
        Vector3 targetPosition = positionB.position;

        while (true)
        {
            // Moverse hacia la posición objetivo
            while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            // Cambiar la posición objetivo a la otra posición
            targetPosition = targetPosition == positionA.position ? positionB.position : positionA.position;
        }
    }
}
