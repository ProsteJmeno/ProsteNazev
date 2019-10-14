using System.Collections;
using UnityEngine;

namespace Assets.scripts
{
    class GameIntro : GameplayPart
    {
        public Rigidbody2D cat;
        public float randomRotation;
        public float waitTime;

        private void Start()
        {
            float randomTorque = UnityEngine.Random.Range(-5000, 5000);
            cat.AddTorque(randomTorque * randomRotation);
            StartCoroutine(WaitForFinish());
        }

        private IEnumerator WaitForFinish()
        {
            yield return new WaitForSeconds(waitTime);
            Time.timeScale = 0;
            Finished();
        }
    }
}
