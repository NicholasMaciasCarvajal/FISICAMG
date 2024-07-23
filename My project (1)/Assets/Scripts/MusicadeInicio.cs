using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicadeInicio : MonoBehaviour
{
    public AudioSource[] musica;
    public int currentMusic;

    /*
    public static MusicadeInicio Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    */

    private void Start()
    {
        currentMusic = -1;
        PlayRandomMusic();
    }

    public void EnableMusic(int index)
    {
        StopAllMusic();

        if (index >= 0 && index < musica.Length)
        {
            musica[index].Play();
            currentMusic = index;
        }
        else
        {
            Debug.LogWarning("Índice de música fuera de rango");
        }
    }


    public void StopAllMusic()
    {
        foreach (AudioSource audio in musica)
        {
            audio.Stop();
        }
    }

    private void PlayRandomMusic()
    {
        if (musica.Length > 0)
        {
            int randomIndex = Random.Range(0, musica.Length); 
            EnableMusic(randomIndex); 
        }
        else
        {
            Debug.LogWarning("No hay música disponible en el arreglo.");
        }
    }
}
