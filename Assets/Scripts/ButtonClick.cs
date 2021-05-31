using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    Inventory_slot_script inventory_slot;

    private void Start()
    {
        inventory_slot = gameObject.GetComponentInParent<Inventory_slot_script>();
    }
    public void Click()
    {
        if (inventory_slot != null)
        {
            inventory_slot.UseItem();
        }
    }
}
