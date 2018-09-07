using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public static GameObject objectDragged;
    private Vector3 objectDraggedPosition;
    private Transform objectDraggedParent;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        objectDragged = gameObject;
        objectDraggedPosition = this.transform.position;
        objectDraggedParent = this.transform.parent;

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
 
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }
 
    public void OnEndDrag(PointerEventData eventData)
    {
        objectDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (transform.parent == objectDraggedParent)
        {
            transform.position = objectDraggedPosition;
        }
        
    }
	
}
