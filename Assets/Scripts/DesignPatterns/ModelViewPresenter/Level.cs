using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ModelViewPresenter
{
    public class Level : MonoBehaviour
    {
        public event Action OnLevelUpAction;
        public event Action OnExperienceChange;

        [SerializeField] int pointsPerLevel = 200;
        private int _experiencePoints;

        public void GainExperience(int points)
        {
            int level = GetLevel();
            _experiencePoints += points;
            OnExperienceChange?.Invoke();

            if (GetLevel() > level)
                OnLevelUpAction?.Invoke();
        }

        public int GetExperience()
        {
            return _experiencePoints;
        }

        public int GetLevel()
        {
            return _experiencePoints / pointsPerLevel;
        }
    }
}