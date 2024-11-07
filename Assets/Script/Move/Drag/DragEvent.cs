using UnityEngine;
using UnityEngine.EventSystems;

public class DragEvent : MonoBehaviour
{
    Vector3 dragPos;

    public void OnPointerDown(BaseEventData data)
    {
        var p = data as PointerEventData;
        Vector3 mousePos = p.position;
        this.dragPos = Camera.main.WorldToScreenPoint(transform.position) - mousePos;
    }

    public void OnDrag(BaseEventData data)
    {
        var p = data as PointerEventData;
        Vector3 mousePos = p.position;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos + this.dragPos);
    }
}
