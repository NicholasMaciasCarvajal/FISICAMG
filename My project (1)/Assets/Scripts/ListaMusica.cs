using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaMusica : MonoBehaviour
{
    public GameObject musicPanel;
    public AudioSource[] musica;
    public int currentMusic;

    public static ListaMusica Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        currentMusic = -1;
        Time.timeScale = 1f;
    }

    public void EnableMusic(int index)
    {
        //if (musicadeInicio != null)
        //{
        //    musicadeInicio.StopAllMusic();
        //}

        StopAllMusic(); // Detener todas las canciones de este script

        musica[index].Play(); // Reproducir la canción especificada
        currentMusic = index;
    }

    private void StopAllMusic()
    {
        foreach (AudioSource audio in musica)
        {
            audio.Stop();
        }
    }
}
