using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tierra : MonoBehaviour
{

    private Image imagen;
    public int nivelSustrato;

    private void Awake()
    {
        imagen = GetComponent<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        switch (nivelSustrato)
        {
            case 0:
                imagen.sprite = ControlNivel.instancia.spriteTierra;
                break;
            case 1:
                imagen.sprite = ControlNivel.instancia.spriteSustrato1;
                break;
            case 2:
                imagen.sprite = ControlNivel.instancia.spriteSustrato2;
                break;
            case 3:
                imagen.sprite = ControlNivel.instancia.spriteSustrato3;
                break;
        }
    }
}
