using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_slot_script : MonoBehaviour
{
    Pickup_scriptableObject pickup;
    public Image pickup_icon;
    //public int index;
    public void Add_pickup(Pickup_scriptableObject new_pickup)
    {
        pickup = new_pickup;
        pickup_icon.sprite = pickup.pickup_icon;
        pickup_icon.enabled = true;
    }
    public void Clear_slot()
    {
        pickup = null;
        pickup_icon.sprite = null;
        pickup_icon.enabled = false;
    }

    public void UseItem()
    {
        if (pickup != null)
        {

        }
    }
}
