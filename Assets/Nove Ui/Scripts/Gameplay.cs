using Assets.scripts;
using UnityEngine;

namespace Assets.Nove_Ui.Scripts
{
    public class Gameplay : GameplayPart
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

        public void stopMoving()
        {
            cat.simulated = false;
        }
    }
}
