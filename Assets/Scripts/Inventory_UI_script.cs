using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UI_script : MonoBehaviour
{
    public Transform slots_parent;
    Inventory_slot_script[] pickup_slots;

    // Start is called before the first frame update
    void Start()
    {
        Inventory_script.instance.onItemChangedCallback += UpdateUI;
        pickup_slots = slots_parent.GetComponentsInChildren<Inventory_slot_script>();
    }

    void UpdateUI()
    {
        for (int i = 0; i < pickup_slots.Length; i++)
        {
            if (i < Inventory_script.instance.pickup_list.Count)
            {
                pickup_slots[i].Add_pickup(Inventory_script.instance.pickup_list[i]);
            }
            else
            {
                pickup_slots[i].Clear_slot();
            }
        }
    }
}
