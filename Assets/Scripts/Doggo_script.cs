using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Doggo_script : MonoBehaviour
{
    public Vector3 m_move;
    public float m_speed = 5f;
    public Rigidbody2D rb;
    public Animator m_anim;
    private BoxCollider2D bx_coll;
    [SerializeField] private LayerMask m_platforms;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        bx_coll = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        m_move = new Vector3(Input.GetAxis("Horizontal"), 0.0f);
        transform.position = transform.position + (m_move * m_speed * Time.deltaTime);

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * m_speed;
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D m_hit = Physics2D.BoxCast(bx_coll.bounds.center, bx_coll.bounds.size, 0f, Vector2.down, .1f, m_platforms);
        //Debug.Log(m_hit.collider);
        return m_hit.collider != null;
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.CompareTag("Pickup"))
        {
            bool isPickedUp = Inventory_script.instance.Add_item(GetComponent<Pickup>().pickup);
            if (isPickedUp)
            {
                gameObject.SetActive(false);
                Debug.Log("Picked up item");
            }
        }

    }*/

}
