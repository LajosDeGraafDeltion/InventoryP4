using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string itemName;
    public string itemDesc;
    public int itemID;
    public Sprite itemIcon;
    public GameObject itemObject;

    public void OnMouseEnter()
    {
        transform.parent.parent.GetComponent<InventoryManager>().selectedItem = gameObject;
    }
}