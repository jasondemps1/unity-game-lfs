using System;
using UnityEngine;

namespace StarterAssets
{
    public class Health : MonoBehaviour
    {
        public int Value;

        public void Awake()
        {
            Value += 5;
        }

        public void Update()
        {
            if (Value > 10)
            {
                Value = 0;
            }
        }

        public void OnDestroy()
        {
        }
    }
}
