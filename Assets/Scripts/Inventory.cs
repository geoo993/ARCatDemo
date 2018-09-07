using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IHasChanged {
    
    [SerializeField] public Transform slots;
    [SerializeField] public Text inventoryText;
    
    // Use this for initialization
    void Start () {
        
    }
    
    public void HasChanged() {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" Complete the word ");
        foreach(Transform slotTranform in slots) {
            GameObject item = slotTranform.GetComponent<Slot>().item;
            if (item) {
                builder.Append(item.name);
                //builder.Append(" - ");
            }
        }
        inventoryText.text = builder.ToString();
    }
}

namespace UnityEngine.EventSystems {

    public interface IHasChanged: IEventSystemHandler {
        void HasChanged();
    }

}