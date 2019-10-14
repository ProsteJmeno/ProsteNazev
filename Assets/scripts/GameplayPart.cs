using System;
using UnityEngine;

namespace Assets.scripts
{
    public abstract class GameplayPart : MonoBehaviour
    {
        public event Action OnEnd;

        public void Finished()
        {
            OnEnd();
        }
    }
}
