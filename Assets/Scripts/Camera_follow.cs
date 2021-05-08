using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public GameObject m_character;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(m_character.transform.position.x, transform.position.y, transform.position.z);

    }
}
