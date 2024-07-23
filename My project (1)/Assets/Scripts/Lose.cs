using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject losePanel; // El panel que se activará al ganar
    public GameObject enemy; // El enemigo específico que debe ser derrotado

    void Start()
    {
        // Asegúrate de que el panel esté desactivado al inicio del juego
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
