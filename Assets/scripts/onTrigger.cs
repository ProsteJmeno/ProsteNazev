using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger : MonoBehaviour
{
    //public Collider2D collider1;
    //public Collider2D collider2;
    public Rigidbody2D cat;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cat.velocity = -cat.velocity;
    }
}
