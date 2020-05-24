using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{
    public static ControlNivel instancia;
    public Sprite spriteTierra;
    public Sprite spriteSustrato1;
    public Sprite spriteSustrato1a;
    public Sprite spriteSustrato1b;
    public Sprite spriteSustrato2;
    public Sprite spriteSustrato2a;
    public Sprite spriteSustrato2b;
    public Sprite spriteSustrato3;
    public Sprite spriteSustrato3a;
    public Sprite spriteSustrato3b;

    private void Awake()
    {
        //Si no tenemos un Manejador de musica activo. . . 
        if (ControlNivel.instancia == null)
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
    }

    public void CambiarSustrato1(int opcionS1)
    {
        switch (opcionS1)
        {
            case 1:
                spriteSustrato1 = spriteSustrato1a;
                break;
            case 2:
                spriteSustrato1 = spriteSustrato1b;
                break;
        }
    }
    public void CambiarSustrato2(int opcionS2)
    {
        switch (opcionS2)
        {
            case 1:
                spriteSustrato2 = spriteSustrato2a;
                break;
            case 2:
                spriteSustrato2 = spriteSustrato2b;
                break;
        }
    }
    public void CambiarSustrato3(int opcionS3)
    {
        switch (opcionS3)
        {
            case 1:
                spriteSustrato3 = spriteSustrato3a;
                break;
            case 2:
                spriteSustrato3 = spriteSustrato3b;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
