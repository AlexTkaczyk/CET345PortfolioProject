using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_scroll : MonoBehaviour
{
    private float sprite_length, start_pos;
    public GameObject m_camera;
    public float m_parallax;

    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position.x;
        sprite_length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (m_camera.transform.position.x * (1 - m_parallax));
        float m_distance = (m_camera.transform.position.x * m_parallax);

        transform.position = new Vector3(start_pos + m_distance, transform.position.y, transform.position.z);
    
        if(temp > start_pos + sprite_length)
        {
            start_pos += sprite_length;
        }
        else if (temp < start_pos - sprite_length)
        {
            start_pos -= sprite_length;
        }
    
    }
}
