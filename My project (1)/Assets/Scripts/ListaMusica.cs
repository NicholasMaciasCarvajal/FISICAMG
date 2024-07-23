using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaMusica : MusicadeInicio
{
    public GameObject musicPanel;
    public AudioSource[] musica;
    public int currentMusic;

    public MusicadeInicio musicadeInicio;

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
    }

    public void EnableMusic(int index)
    {
        //if (musicadeInicio != null)
        //{
        //    musicadeInicio.StopAllMusic();
        //}

        StopAllMusic(); // Detener todas las canciones de este script

        if (index >= 0 && index < musica.Length)
        {
            musica[index].Play(); // Reproducir la canción especificada
            currentMusic = index;
            if (musicadeInicio != null)
            {
                musicadeInicio.StopAllMusic();
            }
        }
        else
        {
            Debug.LogWarning("Índice de música fuera de rango");
        }
    }

    private void StopAllMusic()
    {
        foreach (AudioSource audio in musica)
        {
            audio.Stop();
        }
    }
}
