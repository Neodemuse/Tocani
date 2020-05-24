using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    string nivelNombre;
    public AudioClip cancion;

    private void Awake()
    {
        ManejadorMusica.instancia.CambiaMusica(cancion);
    }

    public void CambiarEscena(string nombre)
    {
        //Solo se usa en el menu principal para cambiar a el menu de niveles o a creditos
        SceneManager.LoadScene(nombre);
    }
}
