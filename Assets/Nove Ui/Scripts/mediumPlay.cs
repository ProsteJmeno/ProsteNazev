using Assets.scripts;
using UnityEngine;

namespace Assets.Nove_Ui.Scripts
{
    public class mediumPlay : GameplayPart
    {
        public Rigidbody2D cat;
        public float pushEffect;
        public float offset;
        public float moveEffect;
        public float widthOffset;
        public int direction;




        public void stopMoving()
        {
            cat.simulated = false;
        }


        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cat.transform.position = new Vector2(cat.transform.position.x, cat.transform.position.y + pushEffect);
                cat.transform.position = new Vector2(cat.transform.position.x + moveEffect * direction, cat.transform.position.y);
            }

            //cat.transform.Translate(new Vector3(moveEffect*direction*Time.deltaTime, 0, 0));
            cat.velocity = new Vector2(moveEffect, cat.velocity.y);

        }

    }
}

