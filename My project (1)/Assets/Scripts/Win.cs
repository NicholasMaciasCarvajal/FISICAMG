using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winPanel; // El panel que se activará al ganar
    public GameObject enemy; // El enemigo específico que debe ser derrotado

    void Start()
    {
        // Asegúrate de que el panel esté desactivado al inicio del juego
        winPanel.SetActive(false);
    }

    void Update()
    {
        // Verificar si el enemigo ha sido destruido
        if (enemy == null)
        {
            ActivateWinPanel();
        }
    }

    void ActivateWinPanel()
    {
        // Activar el panel de victoria
        winPanel.SetActive(true);
    }
}
