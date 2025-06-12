using System;
using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;
        public SoundManager soundManager;
        public UIManager uiManager;
        
        public static float timer;
        public static int score;
        public static bool isPlay = false;
        public static bool isGameOver = false;
        

        private void Start()
        {
            soundManager.SetBGMSound(true);
        }

        void Update()
        {
            // 게임 시작 안하면 밑에있는걸 안함
            if(!isPlay) return;
            if (isGameOver)
            {
                uiManager.GameOver();
            }
            
            timer += Time.deltaTime;
            // 0 <- 뒤의 매개변수중 첫번째 거 가져온다
            // :f1 소숫점 한자리까지 가져온다
            playTimeUI.text = string.Format("플레이 시간 : {0:f1}초", timer);
            
            scoreUI.text = $"X {score}";
        }
    }
}