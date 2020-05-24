using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Semillas : MonoBehaviour, IPointerDownHandler
{
    public GameObject semilla;
    public Transform canvas;
    public int cantidad;
    public Text texto;
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (cantidad > 0)
        {
            cantidad = cantidad - 1;
            Instantiate(semilla, canvas);
        }
        texto.text = "" + cantidad;
        Debug.Log("Hola");
    }

    void OnMouseOver()
    {
        Debug.Log("Mensaje de Prueba");
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
