using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public Ability_scriptableObject ability;
    public Enemy[] enemy;
    public GameObject player;
    public AudioSource bark;
    public void UseAbility()
    {
       if(Vector3.Distance(enemy[0].transform.position, player.transform.position) < 5) 
       {
            if (ability.ability_name == "Mighty Bork")
            {
                Debug.Log("Mighty Bork");
                bark.Play();
                //enemy_obj.enemy_health += enemy_obj.enemy_health - ability.ability_damage;
                //Debug.Log(enemy_obj.enemy_health - ability.ability_damage);
                enemy[0].enemy_health -= ability.ability_damage;
                if(enemy[0].enemy_health <= 0)
                {
                    Destroy(enemy[0].gameObject);
                }

                Debug.Log(enemy[0].enemy_health);
            }
       }
        
        /*if (ability.ability_name == "Growl of Fear")
        {
            Debug.Log("Growl of Fear");
        }*/

        if (ability.ability_name == "Tail wag of Storm")
        {
            Debug.Log("Tail wag Storm");
            enemy[0].enemy_health -= ability.ability_damage;
            if (enemy[0].enemy_health <= 0)
            {
                Destroy(enemy[0].gameObject);
            }

            Debug.Log(enemy[0].enemy_health);
        }

    }
}
