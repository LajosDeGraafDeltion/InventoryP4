using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public Transform selectedSlot, originalSlot;
    public GameObject selectedItem;
    public Image test;
    public Image currentIcon;
    public List<GameObject> playerInv = new List<GameObject>();
    public bool selected;


    private void Start()
    {
        currentIcon.enabled = false;
    }

    public void Update()
    {

        currentIcon.transform.position = Input.mousePosition;

        if (Input.GetMouseButtonDown(0) && selectedItem != null && test == null)
        {
            test =  selectedItem.GetComponent<Image>();

            currentIcon.sprite = test.sprite;
            print(currentIcon);
            test.enabled = false;
            currentIcon.enabled = true;
            selected = true;
        }
        if (Input.GetMouseButton(0) && selectedItem != null && test == null)
        {
            selectedItem.transform.position = Input.mousePosition;
            //Zodra test gevuld is mag selectedItem niet vullen;
            if(selectedItem != null)
            {
                //Zet Item Hover/onEnter uit.
            }

        }
        else if (Input.GetMouseButtonUp(0) && selectedItem != null)
        {
            selectedItem.transform.SetParent(selectedSlot, false);
            selectedItem.transform.localPosition = Vector3.zero;
            test.enabled = true;
            currentIcon.enabled = false;
            selectedItem = null;
            selected = false;
            test = null;
        }
    }

    public void ExitItem()
    {
        if (selected == false)
        {
            selectedItem = null;
        }
    }

}
