using UnityEngine;
using UnityEngine.EventSystems;
public class CellScr : MonoBehaviour, IDropHandler
{
    public MapGenerator mapGenerator;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DrugAndDrop>().isDragable == true)
            {
                if (eventData.pointerDrag.gameObject.name == gameObject.name)
                {
                    eventData.pointerDrag.GetComponent<DrugAndDrop>().isDragable = false;
                    eventData.pointerDrag.GetComponent<CanvasGroup>().alpha = 1f;
                    mapGenerator = GetComponentInParent<MapGenerator>();
                    mapGenerator.amount++;
                }
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
        }
    }

    // Start is called before the first frame update

}
