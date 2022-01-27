using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.ModelViewPresenter
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] Health health;
        [SerializeField] Slider healthBar;

        private void Start()
        {
            health.OnHealthChange += UpdateUI;
            UpdateUI();
        }

        private void UpdateUI()
        {
            healthBar.value = health.GetHealth() / health.GetFullHealth();
        }
    }
}