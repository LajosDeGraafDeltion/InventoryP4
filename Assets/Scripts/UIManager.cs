using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public bool invToggle;
    public GameObject uiInv;

    public void Update()
    {
        if (Input.GetButtonDown("E"))
        {
            invToggle = !invToggle;
            InventorySwitch();
        }
    }

    public void InventorySwitch()
    {
        if (invToggle == true)
        {
            uiInv.SetActive(true);
        }

        else
        {
            uiInv.SetActive(false);
        }
    }
}
