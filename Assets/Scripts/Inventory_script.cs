using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_script : MonoBehaviour
{
    public static Inventory_script instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance");
            return;
        }
        instance = this;
    }

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int pickup_slots = 2;
    public List<Pickup_scriptableObject> pickup_list = new List<Pickup_scriptableObject>();
    public Inventory_slot_script inventory_slot;
    public bool Add_item(Pickup_scriptableObject pickup)
    {
        for (int i = 0; i < pickup_list.Count; i++)
        {
            if (pickup_list[i].pickup_name == pickup.pickup_name)
            {
                pickup_list[i].pickup_amount++;
                
                return true;
            }
        }  
        
        pickup_list.Add(pickup);
        //Debug.Log(pickup_list.Count);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

        return true;
    }
}
