﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pickup", menuName = "Pickups/Pickup")]
public class Pickup_scriptableObject : ScriptableObject
{  
    public string pickup_name = "New Pickup";
    public Sprite pickup_icon = null;
    public int pickup_amount = 1;

    public virtual void Use()
    {

    }
}
