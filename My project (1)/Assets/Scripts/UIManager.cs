using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<Image> listaCorazones;
    [SerializeField] private Sprite corazonLleno;
    [SerializeField] private Sprite corazonMedio;
    [SerializeField] private Sprite corazonVacio;

    public void ActualizarCorazones(int currentHealth)
    {
        for (int i = 0; i < listaCorazones.Count; i++)
        {
            if (currentHealth >= (i + 1) * 2)
            {
                listaCorazones[i].sprite = corazonLleno;
            }
            else if (currentHealth >= i * 2 + 1)
            {
                listaCorazones[i].sprite = corazonMedio;
            }
            else
            {
                listaCorazones[i].sprite = corazonVacio;
            }
        }
    }
}
