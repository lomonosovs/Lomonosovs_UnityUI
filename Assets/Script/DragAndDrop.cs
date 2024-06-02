using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    void Start()
    {
        rTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Izdarīts klikšis uz velkama objekta!");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Uzsākta vilkšana!");
        canvasGroup.alpha = 0.6f; // Сделать объект немного прозрачным при перетаскивании
        canvasGroup.blocksRaycasts = false; // Отключить блокировку лучей для объекта при перетаскивании
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            eventData.position,
            canvas.worldCamera,
            out localPoint
        );

        rTransform.localPosition = localPoint;
        Debug.Log("x=" + localPoint.x + " un y=" + localPoint.y);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Objekts atlaists, vilkšana pārtraukta!");
        canvasGroup.alpha = 1.0f; // Вернуть исходную непрозрачность объекта
        canvasGroup.blocksRaycasts = true; // Включить блокировку лучей для объекта
    }
}


