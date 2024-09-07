using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject losePanel; // El panel que se activar� al ganar
    public GameObject enemy; // El enemigo espec�fico que debe ser derrotado
    public GameObject vidaPanel;

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
