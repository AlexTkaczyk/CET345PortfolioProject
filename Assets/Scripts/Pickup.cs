using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Pickup_scriptableObject pickup;
    public GameObject pickup_obj;
    Inventory_slot_script slots;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            bool isPickedUp = Inventory_script.instance.Add_item(GetComponent<Pickup>().pickup);
            if (isPickedUp)
            {
                Debug.Log(pickup.pickup_amount.ToString());
                Destroy(pickup_obj.gameObject);
            }
        }

    }
}
