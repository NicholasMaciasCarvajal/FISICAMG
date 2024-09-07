using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject losePanel; // El panel que se activará al ganar
    public GameObject enemy; // El enemigo específico que debe ser derrotado
    public GameObject vidaPanel;

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
        vidaPanel.SetActive(false);
        Time.timeScale = 0f;
    }
    // Funcion para salir del juego
    public void ExitGame()
    {
        Application.Quit();
    }

    // Funcion para cargar una escena especifica
    public void LoadScene(int _index)
    {
        SceneManager.LoadScene(_index);
    }

    // Funcion para recargar la escena actual
    public void ReLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
