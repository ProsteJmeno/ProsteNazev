using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbmovement : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody2D rb;
    public Vector2 movement;
    bool jump;
    public float JumpForce;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), 0);
        jump = Input.GetKeyDown(KeyCode.Space);
    }
    void FixedUpdate()
    {
        moveCharacter(movement);
       
    }
    void moveCharacter(Vector2 direction)
    {
        //insert one of the 3 types of movement here
        rb.velocity = direction * speed;
    }
    void jumpCharacter(bool jump)
    {
        if (jump)
        {
            rb.AddForce(new Vector2 )
        }
    }
    
}
