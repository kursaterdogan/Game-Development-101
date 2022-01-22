using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns.Observer
{
    public class Level : MonoBehaviour
    {
        // Action with parameter
        // public event Action<float> OnLevelUpAction;

        // Usage with UnityEvent
        // public UnityEvent onLevelUp;

        // Usage with Delegate + Event
        // public delegate void CallbackType();
        // public delegate void CallbackType(float level);
        // public event CallbackType OnLevelUp;

        public event Action OnLevelUpAction;

        private int pointsPerLevel = 200;
        private int _experiencePoints;

        private IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.2f);
                GainExperience(10);
            }
        }

        private void GainExperience(int points)
        {
            int level = GetLevel();
            _experiencePoints += points;

            if (GetLevel() > level)
            {
                OnLevelUpAction?.Invoke();

                // Without ?.invoke
                // if (OnLevelUpAction != null)
                // {
                //     OnLevelUpAction();
                // }
            }
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