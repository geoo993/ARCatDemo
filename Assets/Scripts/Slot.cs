﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

    public GameObject item {
        get {
            if (transform.childCount > 0) {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            if (gameObject.tag == "QuestionMarkSlot" && DragHandler.objectDragged.tag == "CorrectLetter")
            {
                DragHandler.objectDragged.transform.SetParent(transform);
                ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
                GameObject.Find("GameManager").GetComponent<GameManager>().WordCorrect();
            }
        }
    }
}
