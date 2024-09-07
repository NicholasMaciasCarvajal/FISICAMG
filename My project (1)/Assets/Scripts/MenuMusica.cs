using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusica : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject vidaPanel;

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        vidaPanel.SetActive(false);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        vidaPanel.SetActive(true);
    }
}
