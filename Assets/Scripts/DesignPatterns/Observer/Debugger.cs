using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class Debugger : MonoBehaviour
    {
        IEnumerator Start()
        {
            Health health = GetComponent<Health>();
            Level level = GetComponent<Level>();
            while (true)
            {
                yield return new WaitForSeconds(1);
                Debug.Log($"Exp: {level.GetExperience()}, Level: {level.GetLevel()}, Health: {health.GetHealth()}");
            }
        }
    }
}