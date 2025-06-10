using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;
        public GameObject playUI;
        public GameObject playOBJ;
        public GameObject introUI;
        public Button startButton;

        public SoundManager soundManager;

        private void Awake()
        { 
            playOBJ.SetActive(false);
            introUI.SetActive(true);
            playUI.SetActive(false);
        }

        void Start()
        {
            startButton.onClick.AddListener(OnStartEvent);
        }
        
        public void OnStartEvent()
        {
            if (inputField.text == "")
                nameTextUI.text = "나비"; // Default
            else
                nameTextUI.text = inputField.text;
            
            playUI.SetActive(true);
            playOBJ.SetActive(true);
            introUI.SetActive(false);
            GameManager.isPlay = true;
            
            soundManager.SetBGMSound(false);
        }

        public void GameOver()
        {
            playUI.SetActive(false);
        }
    }
    
}

