using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landing : MonoBehaviour
{
    bool col;

    float enterTime;
    float stayTime = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            col = true;
            enterTime = Time.time;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (col)
        {
            if(Time.time - enterTime >= stayTime)
            {
                print("succes");
            }
        }
    }
}
