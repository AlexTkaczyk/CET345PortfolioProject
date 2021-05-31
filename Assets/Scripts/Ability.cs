using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public Ability_scriptableObject ability;
    public Enemy[] enemy;
    public GameObject player;
    public Animator animator;
    public void UseAbility()
    {
       if(enemy[0] != null && Vector3.Distance(enemy[0].transform.position, player.transform.position) < 6) 
       {
            if (ability.ability_name == "Mighty Bork")
            {
                Debug.Log("Mighty Bork");
                ability.ability_damage = Random.Range(0, 35);
                enemy[0].enemy_health -= ability.ability_damage;
                if (enemy[0].enemy_health <= 0)
                {
                    StartCoroutine(Ice_death_animation());
                }
            }

            if (ability.ability_name == "Growl of Fear")
            {
                Debug.Log("Growl of Fear");
                ability.ability_damage = Random.Range(0, 20);
                enemy[0].enemy_health -= ability.ability_damage;
                if (enemy[0].enemy_health <= 0)
                {
                    StartCoroutine(Monkey_death_animation());
                }
            }

            if (ability.ability_name == "Tail wag of Storm")
            {
                Debug.Log("Tail wag Storm");
                ability.ability_damage = Random.Range(0, 25);
                enemy[0].enemy_health -= ability.ability_damage;
                if (enemy[0].enemy_health <= 0)
                {
                    StartCoroutine(Fire_death_animation());
                }
            }
        }

    }
     IEnumerator Ice_death_animation()
     {
        animator.Play("Ice_monster_death_animation");
        yield return new WaitForSeconds(3);
        Destroy(enemy[0].gameObject);
     }

    IEnumerator Fire_death_animation()
    {
        animator.Play("Fire_bird_death_animation");
        yield return new WaitForSeconds(3);
        Destroy(enemy[0].gameObject);
    }

    IEnumerator Monkey_death_animation()
    {
        animator.Play("Monkey_death_animation");
        yield return new WaitForSeconds(3);
        Destroy(enemy[0].gameObject);
    }

}
