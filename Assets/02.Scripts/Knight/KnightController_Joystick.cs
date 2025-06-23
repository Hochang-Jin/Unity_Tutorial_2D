using System;
using UnityEngine;

public class KnightController_Joystick : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpPower = 8f;

    private bool isGround;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }
    

    void Move()
    {
        if (inputDir.x != 0)
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isGround) return;
            animator.SetTrigger("Jump");
            animator.SetBool("isGround", false);
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            isGround = false;
        }
        
        if(knightRb.linearVelocityY < 0 )
            animator.SetBool("isFall", true);
    }

    void SetAnimation()
    {
        if (inputDir.x != 0)
            animator.SetBool("isRun", true);
        else if (inputDir.x == 0)
            animator.SetBool("isRun", false);

        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;

            animator.SetBool("isFall", false);
        }
    }
}
