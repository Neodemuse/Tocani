using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;

    private RectTransform transform;
    private CanvasGroup canvasgroup;

    private void Awake()
    {
        transform = GetComponent<RectTransform>();
        canvas = gameObject.GetComponentInParent<Canvas>();
        canvasgroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasgroup.blocksRaycasts = false;
        Debug.Log("Vas bien");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasgroup.blocksRaycasts = true;
        Debug.Log("Termina Bien");
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Hola");
    }


    void OnMouseOver()
    {
        Debug.Log("Mensaje de Prueba");
    }

}
