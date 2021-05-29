using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public Ability_scriptableObject ability;
    public void UseAbility()
    {
        if (ability.ability_name == "Mighty Bork")
        {
            Debug.Log("Mighty Bork");
        }

        if (ability.ability_name == "Growl of Fear")
        {
            Debug.Log("Growl of Fear");
        }

        if (ability.ability_name == "Tail wag of Storm")
        {
            Debug.Log("Tail wag Storm");
        }

    }
}
