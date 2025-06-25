using System;
using UnityEngine;

public class KnightController_Keyboard : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpPower = 8f;
    
    private float attackDamage = 3f;
    
    private bool isCombo;
    private bool isAttack;
    private bool isGround;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        InputKeyboard();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void InputKeyboard()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        inputDir = new Vector3(h, v, 0);
        animator.SetFloat("JoystickX",inputDir.x);
        animator.SetFloat("JoystickY",inputDir.y);
        
        if(Input.GetKeyDown(KeyCode.Z))
            Attack();
        
        Jump();
    }
    
    void Attack()
    {
        if (!isAttack)
        {
            attackDamage = 3f;
            isAttack = true;
            animator.SetTrigger("Attack");
        }
        else
        {
            isCombo = true;
        }
    }
    
    public void CheckCombo()
    {
        if (isCombo)
        {
            attackDamage = 5f;
            animator.SetBool("isCombo", true);
        }
        else
        {
            animator.SetBool("isCombo", false);
            isAttack = false;
        }
    }

    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
    }
    
    void Move()
    {
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
        }
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;

            animator.SetBool("isFall", false);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            Debug.Log($"{attackDamage}로 공격");
        }
    }
}
