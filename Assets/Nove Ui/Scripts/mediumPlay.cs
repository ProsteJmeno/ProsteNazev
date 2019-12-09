using Assets.scripts;
using UnityEngine;

namespace Assets.Nove_Ui.Scripts
{
    public class mediumPlay : GameplayPart
    {
        public Rigidbody2D cat;
        public float pushEffect;

        private void Start()
        {
            Time.timeScale = 1;
        }


        public void stopMoving()
        {
            cat.simulated = false;
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                Debug.Log("něco");
                cat.transform.position = new Vector2(cat.transform.position.x, cat.transform.position.y + pushEffect);
            }
        }
    }
}

