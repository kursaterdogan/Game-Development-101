using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.ModelViewPresenter
{
    public class LevelPresenter : MonoBehaviour
    {
        [SerializeField] Level level;
        [SerializeField] Text levelText;
        [SerializeField] Text experienceText;
        [SerializeField] Button increaseExperienceButton;

        private void Start()
        {
            increaseExperienceButton.onClick.AddListener(GainExperience);
            level.OnExperienceChange += UpdateUI;
            UpdateUI();
        }

        private void GainExperience()
        {
            level.GainExperience(50);
        }

        private void UpdateUI()
        {
            levelText.text = $"Level: {level.GetLevel()}";
            experienceText.text = $"XP: {level.GetExperience()}";
        }
    }
}