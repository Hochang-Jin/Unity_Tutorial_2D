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
        public Button restartButton;
        public GameObject outroPanel;

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
            restartButton.onClick.AddListener(OnRestartEvent);
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

        public void OnRestartEvent()
        {
            playUI.SetActive(true);
            playOBJ.SetActive(true);

            GameManager.score = 0;
            GameManager.isPlay = true;
            GameManager.isGameOver = false;
            GameManager.timer = 0;
            
            outroPanel.SetActive(false);
        }
        
        public void GameOver()
        {
            playUI.SetActive(false);
        }
    }
    
}

