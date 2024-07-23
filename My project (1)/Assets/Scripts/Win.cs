using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winPanel; // El panel que se activar� al ganar
    public GameObject enemy; // El enemigo espec�fico que debe ser derrotado

    void Start()
    {
        // Aseg�rate de que el panel est� desactivado al inicio del juego
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
