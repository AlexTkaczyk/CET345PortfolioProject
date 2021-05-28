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

    //public int ability_slots = 3;
    public int pickup_slots = 2;
    public List<Pickup_scriptableObject> pickup_list = new List<Pickup_scriptableObject>();
    //public List<Ability_scriptableObject> ability_list = new List<Ability_scriptableObject>();

    public bool Add_item(Pickup_scriptableObject pickup)
    {
        pickup_list.Add(pickup);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

        return true;
    }
}
