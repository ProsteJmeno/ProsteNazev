using UnityEngine;

namespace Assets.scripts
{
    class GameManager : MonoBehaviour
    {
        public GameplayPart[] parts;

        private int partIndex;

        private void Start()
        {
            foreach(var part in parts)
            {
                part.OnEnd += () =>
                {
                    partIndex++;
                    GoToNext();
                };
            }
            GoToNext();
        }

        private void GoToNext()
        {
            for(int i = 0; i < parts.Length; i++)
            {
                parts[i].enabled  = i == partIndex;
            }
        }
    }
}
