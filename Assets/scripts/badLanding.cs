using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badLanding : MonoBehaviour
{
    public GameObject deadScreen;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            catDied();
        }
    }
    public void catDied()
    {
        deadScreen.SetActive(true);
    }
}

