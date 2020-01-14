﻿using Assets.Nove_Ui.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badLandingOnMedium : MonoBehaviour
{
    public GameObject deadScreen;
    public mediumGameplay gameplay;
    public bool dead;
    private void Start()
    {
        dead = false;
    }
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
        gameplay.stopMoving();
        dead = true;
    }
}
