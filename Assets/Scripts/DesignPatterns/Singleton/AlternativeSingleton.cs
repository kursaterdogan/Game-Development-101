using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class AlternativeSingleton : MonoBehaviour
    {
        [SerializeField] GameObject persistentObjectPrefab;
        static bool hasSpawned;

        private void Awake()
        {
            SetUpSingleton();
        }

        private void SetUpSingleton()
        {
            if (hasSpawned) return;

            GameObject persistentObject = Instantiate(persistentObjectPrefab);
            DontDestroyOnLoad(persistentObject);
            hasSpawned = true;
        }
    }
}