using System;
using UnityEngine;
using UnityEngine.UI;

namespace Nove_Ui.Scripts
{
    public class LevelButton : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Text label;
        [SerializeField] private Button button;

        public event Action OnButtonClicked = () => { };

        public string Label
        {
            get => label.text;
            set => label.text = value;
        }

        public bool Unlocked
        {
            get => button.interactable;
            set => button.interactable = value;
        }

        private void Awake()
        {
            button.onClick.AddListener(() =>
            {
                if (Unlocked)
                    OnButtonClicked();
            });
        }
    }
}