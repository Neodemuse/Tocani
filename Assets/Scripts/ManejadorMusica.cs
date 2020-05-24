using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-10)]
public class ManejadorMusica : MonoBehaviour
{
    public static ManejadorMusica instancia;
    AudioSource manejaAudio;
    AudioClip musica;
    //Se llama cuando se instancia el script
    private void Awake()
    {
        //Si no tenemos un Manejador de musica activo. . . 
        if (ManejadorMusica.instancia == null)
        {
            //...hacemos que este sea el activo...
            instancia = this;
        }
        //...en otro caso...
        else if (instancia != this)
        {
            //Destruimos este objeto porque se ha duplicado.
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        manejaAudio = GetComponent<AudioSource>();
        musica = GetComponent<AudioClip>();
    }

    public void CambiaMusica(AudioClip cancion)
    {
        if (cancion != musica)
        {
            manejaAudio.clip = cancion;
        }
        if (!manejaAudio.isPlaying)
        {
            manejaAudio.Play();
        }
    }

    public void DetenerMusica()
    {
        manejaAudio.Pause();
    }
}
