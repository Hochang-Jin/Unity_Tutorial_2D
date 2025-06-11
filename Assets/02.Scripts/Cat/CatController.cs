using System;
using System.Collections;
using Cat;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRB;
    private Animator catAnim;
    
    // 점프 소리 재생
    [SerializeField]
    private SoundManager soundManager;
    [SerializeField]
    private VideoManager videoManager;
  
    public GameObject gameOverUI;
    public GameObject fadeUI;
    
    // 최대 점프 횟수
    [SerializeField]
    private int maxJumpCount = 3;
    [SerializeField]
    private int jumpCount = 0;
    
    [SerializeField]
    private float jumpForce = 10f;
    public float limitPower = 9f;
    
    void Start()
    {
        catRB = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumpCount)
        {
            catRB.AddForceY(jumpForce, ForceMode2D.Impulse);
            catAnim.SetTrigger("Jump");
            jumpCount++;
            soundManager.OnJumpSound();
            
            if (catRB.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
                catRB.linearVelocityY = limitPower;
        }
        
        // 고양이 회전
        var catRotation = transform.eulerAngles;
        catRotation.z = catRB.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            // 사과 이미지 끄기
            other.gameObject.SetActive(false);
            // 점수 추가
            GameManager.score++; // score가 static이기 때문에 GameManager 클래스에서 접근 가능
            // 파티클 켜기
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);
            
            // 10개 이상의 사과를 먹었을 때 게임 클리어
            if (GameManager.score == 10)
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f,Color.white);
                // Cat Collider off
                this.GetComponent<CircleCollider2D>().enabled = false;
                
                // Invoke(nameof(HappyVideo),4f);
                StartCoroutine(EndingRoutine(true));
                GameManager.isGameOver = true;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            catAnim.SetTrigger("Ground");
        }
        else if(other.gameObject.CompareTag("Enemy"))
        {
            // TODO : FADE, SOUND, OUTRO
            // Sound
            soundManager.OnCollisionSound();
            // Fade, Outro
            gameOverUI.SetActive(true);
            fadeUI.SetActive(true);
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black);
            // Cat Collider off
            this.GetComponent<CircleCollider2D>().enabled = false;
            
            //Invoke(nameof(UnHappyVideo),4f);
            StartCoroutine(EndingRoutine(false));
            
            GameManager.isGameOver = true;
        }
    }

    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(4f);
        videoManager.VideoPlay(isHappy);
        
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);
        soundManager.audioSource.mute = true;
    }
    /* 
    void UnHappyVideo()
    {
        // fadeUI.SetActive(false);
        // gameOverUI.SetActive(false);
        
        videoManager.VideoPlay(false);
        
        soundManager.audioSource.mute = true;
    }
    void HappyVideo()
    {
        // fadeUI.SetActive(false);
        // gameOverUI.SetActive(false);
        
        videoManager.VideoPlay(true);
        
        soundManager.audioSource.mute = true;
    }
     */
}
