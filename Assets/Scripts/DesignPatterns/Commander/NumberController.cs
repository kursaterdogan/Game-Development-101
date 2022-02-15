using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.Commander
{
    public class NumberController : MonoBehaviour
    {
        public static NumberController SharedInstance { get; private set; }

        [SerializeField] private Text numberText;
        private int _number;

        private void Awake()
        {
            SharedInstance = this;
        }

        public void Add(int number)
        {
            _number += number;
            UpdateNumberText();
        }

        public void Subtract(int number)
        {
            _number -= number;
            UpdateNumberText();
        }

        public void Multiply(int number)
        {
            _number *= number;
            UpdateNumberText();
        }

        public void Divide(int number)
        {
            _number /= number;
            UpdateNumberText();
        }

        private void UpdateNumberText()
        {
            numberText.text = _number.ToString();
        }
    }
}