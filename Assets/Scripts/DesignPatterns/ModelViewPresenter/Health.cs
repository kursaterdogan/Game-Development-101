using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ModelViewPresenter
{
    public class Health : MonoBehaviour
    {
        public event Action OnHealthChange;

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

        public float GetHealth()
        {
            return _currentHealth;
        }

        public float GetFullHealth()
        {
            return _fullHealth;
        }

        void ResetHealth()
        {
            _currentHealth = _fullHealth;
            OnHealthChange?.Invoke();
        }

        private IEnumerator HealthDrain()
        {
            while (_currentHealth > 0)
            {
                _currentHealth -= _drainPerSecond;
                OnHealthChange?.Invoke();
                yield return new WaitForSeconds(1);
            }
        }
    }
}