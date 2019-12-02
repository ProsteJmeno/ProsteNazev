using Assets.scripts;
using UnityEngine;

namespace Assets.Nove_Ui.Scripts
{
    public class mediumGameplay : GameplayPart
    {
        public Rigidbody2D cat;
        public float pushEffect;

        private void Start()
        {
            Time.timeScale = 1;
        }

        void pushCat()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Vector2 position = cat.transform.position;
                //cat.transform.position = new Vector2(cat.transform.position.x, cat.transform.position.y + pushEffect);
                print("DEBUG");
            }
        }

        public void stopMoving()
        {
            cat.simulated = false;
        }

        public void Update()
        {
            pushCat();
        }
    }
}

