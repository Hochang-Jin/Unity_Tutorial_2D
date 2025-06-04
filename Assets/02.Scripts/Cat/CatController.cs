using System;
using Cat;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRB;
    private Animator catAnim;
    
    // 점프 소리 재생
    [SerializeField]
    private SoundManager soundManager;
    // 땅 확인
    // private bool isGround = true;
    
    // 최대 점프 횟수
    [SerializeField]
    private int maxJumpCount = 3;
    [SerializeField]
    private int jumpCount = 0;
    
    [SerializeField]
    private float jumpForce = 10f;
    
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
        }
       

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     catRB.AddForceY(jumpForce, ForceMode2D.Impulse);
        // }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // isGround = true;
            jumpCount = 0;
            catAnim.SetTrigger("Ground");
        }
    }

    // private void OnCollisionExit2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Ground"))
    //         catAnim.SetBool("isGround", false);
    // }
}
