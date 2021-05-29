using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory_slot_script : MonoBehaviour
{
    Pickup_scriptableObject pickup;
    public Image pickup_icon;
    public TextMeshProUGUI amount_text;

    //public int index;
    public void Add_pickup(Pickup_scriptableObject new_pickup)
    {
        pickup = new_pickup;
        pickup_icon.sprite = pickup.pickup_icon;
        pickup_icon.enabled = true;
        amount_text.gameObject.SetActive(true);
    }
    public void Clear_slot()
    {
        pickup = null;
        pickup_icon.sprite = null;
        pickup_icon.enabled = false;
        amount_text.enabled = false;
    }

    public void UseItem()
    {
        if (pickup != null)
        {
            if(pickup.pickup_name == "Chicken Leg")
            {
                Debug.Log("ChickenLeg");
            }

            if (pickup.pickup_name == "Growth Serum")
            {
                Debug.Log("Serum");
            }
        }
    }


        
}
