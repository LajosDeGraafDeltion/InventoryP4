using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour {


    public void OnMouseEnter()
    {
        transform.parent.GetComponent<InventoryManager>().selectedSlot = this.transform;
    }

    public void OnMouseExit()
    {
        transform.parent.GetComponent<InventoryManager>().selectedSlot = null;
    }
}
