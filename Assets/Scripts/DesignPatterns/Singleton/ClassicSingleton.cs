using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class ClassicSingleton : MonoBehaviour
    {
        public static ClassicSingleton SharedInstance;

        private void Awake()
        {
            SetUpSingleton();
        }

        private void SetUpSingleton()
        {
            if (!SharedInstance)
            {
                SharedInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (SharedInstance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}