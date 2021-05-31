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
    public GameObject doggo;
    public Animator animator;
    public AudioSource audio_src;
    public Enemy enemy;

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

            if (Vector3.Distance(enemy.transform.position, doggo.transform.position) < 4)
            {
                if (pickup.pickup_name == "Growth Serum")
                {
                    Clear_slot();
                    Debug.Log("Serum");
                    audio_src.Play();
                    StartCoroutine(Doggo_scale_Animation_cooldown());
                }
            }

        }
    }

    IEnumerator Doggo_scale_Animation_cooldown()
    {
        doggo.transform.localScale = new Vector3(2f, 2f, 1f);
        yield return new WaitForSeconds(2);
        animator.Play("Wolf_scared_animation");
        yield return new WaitForSeconds(3);
        Destroy(enemy.gameObject);
        doggo.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
    }


}
