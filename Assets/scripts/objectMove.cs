using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objectMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float distance = 2;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var isGrounded = Physics2D.Linecast(transform.position , transform.position + Vector3.down * distance);
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.velocity = (Vector3.up * 5);
        }
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        rb.AddForce(direction * movementSpeed);
        if (gameObject.transform.position.y <= -3.5)
        {
            SceneManager.LoadScene("level1");
        }

    }
}
