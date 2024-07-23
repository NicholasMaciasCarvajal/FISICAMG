using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject losePanel; // El panel que se activar� al ganar
    public GameObject enemy; // El enemigo espec�fico que debe ser derrotado

    void Start()
    {
        // Aseg�rate de que el panel est� desactivado al inicio del juego
        losePanel.SetActive(false);
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
        losePanel.SetActive(true);
    }
}
