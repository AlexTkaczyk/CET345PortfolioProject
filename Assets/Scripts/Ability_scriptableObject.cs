using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Abilities/Ability")]
public class Ability_scriptableObject : ScriptableObject
{
    public string ability_name = "New Ability";
    public int ability_damage;

    public virtual void Use()
    {

    }
}
