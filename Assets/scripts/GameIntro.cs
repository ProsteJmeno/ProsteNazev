using System.Collections;
using UnityEngine;

namespace Assets.scripts
{
    class GameIntro : GameplayPart
    {
        public Rigidbody2D cat;
        public float randomRotation;
        float randomTorque = 0;


        private void Start()
        {
            while(randomTorque > -500 && randomTorque < 500)
            {
                 randomTorque = UnityEngine.Random.Range(-5000, 5000);
            }
            cat.AddTorque(randomTorque * randomRotation);
        }

    }
}
