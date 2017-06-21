using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public Transform selectedItem, selectedSlot, originalSlot;
    public Image test;
    public Image currentIcon;
    public List<GameObject> playerInv = new List<GameObject>();

    private void Start()
    {
        currentIcon.enabled = false;
    }

    public void Update()
    {

        currentIcon.transform.position = Input.mousePosition;

        if (Input.GetMouseButtonDown(0) && selectedItem != null)
        {
            test =  selectedItem.GetComponent<Image>();

            currentIcon.sprite = test.sprite;
            print(currentIcon);
            test.enabled = false;
            currentIcon.enabled = true;
        }
        if (Input.GetMouseButton(0) && selectedItem != null)
        {
            selectedItem.position = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0) && selectedItem != null)
        {
            selectedItem.transform.SetParent(selectedSlot, false);
            selectedItem.localPosition = Vector3.zero;
            test.enabled = true;
            currentIcon.enabled = false;
        }
    }

}
