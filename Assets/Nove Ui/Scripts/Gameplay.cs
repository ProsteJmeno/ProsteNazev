﻿using UnityEngine;

namespace Assets.Nove_Ui.Scripts
{
    class Gameplay : MonoBehaviour
    {
        public Rigidbody2D cat;
        public float rotateForce;

        private void Start()
        {
            Time.timeScale = 1;
        }

        private void Update()
        {
            cat.AddTorque(Input.GetAxis("Horizontal") * -rotateForce);
        }
    }
}