using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DrugAndDrop : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Canvas canvas;
    RectTransform rectTransform;
    public bool isDragable = true;
    public CanvasGroup canvasGroup;
    void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.7f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragable) 
        {
            rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    // Start is called before the first frame update

}
