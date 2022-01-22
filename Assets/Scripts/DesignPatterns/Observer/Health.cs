using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class Health : MonoBehaviour
    {
        private float _fullHealth = 100f;
        private float _drainPerSecond = 2f;
        private float _currentHealth;

        private void Awake()
        {
            ResetHealth();
            StartCoroutine(HealthDrain());
        }

        private void OnEnable()
        {
            GetComponent<Level>().OnLevelUpAction += ResetHealth;
        }

        private void OnDisable()
        {
            GetComponent<Level>().OnLevelUpAction -= ResetHealth;
        }

        private void ResetHealth()
        {
            _currentHealth = _fullHealth;
        }

        private IEnumerator HealthDrain()
        {
            while (_currentHealth > 0)
            {
                _currentHealth -= _drainPerSecond;
                yield return new WaitForSeconds(1);
            }
        }

        public float GetHealth()
        {
            return _currentHealth;
        }
    }
}