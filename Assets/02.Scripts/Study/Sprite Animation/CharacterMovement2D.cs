using System;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement2D : MonoBehaviour
{
    private Rigidbody2D characterRB;
    private float speed = 3f;
    private float h; // Horizontal Input
    private float jumpPower= 5f;
    private bool isGround = true;
    
    [SerializeField]
    private SpriteRenderer[] renderers;
    
    private void Start()
    {
        characterRB = GetComponent<Rigidbody2D>();
        renderers = GetComponentsInChildren<SpriteRenderer>(true); // 비활성화 돼있는 것도 찾아올 수 있음
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 좌우 이동 및 스프라이트 플립
    /// </summary>
    void Move()
    {
        // 땅이 아니면 함수를 빠져나간다
        if (!isGround)
            return;
                
        if (h == 0) // 키 입력이 없을 땐 idle on, run off
        {
            renderers[0].gameObject.SetActive(true);
            renderers[1].gameObject.SetActive(false);
        }
        else // 키 입력이 있을 땐 idle off, run on
        {
            characterRB.linearVelocity = new Vector2(h * speed, characterRB.linearVelocity.y);
            renderers[0].gameObject.SetActive(false);
            renderers[1].gameObject.SetActive(true);

            // 좌 우 플립
            if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
            else
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }
        }
        /*
         * renderers[0].gameObject.SetActive(h == 0);
         * renderers[1].gameObject.SetActive(h != 0);
         */
        
        // run
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 6f;

        if (Input.GetKeyUp(KeyCode.LeftShift))
            speed = 3f;
        
    }

    private void Jump()
    {
        // jump
        if (Input.GetButtonDown("Jump"))
        {
            isGround = false;
            characterRB.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGround = true;
        renderers[2].gameObject.SetActive(false);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;
        
        renderers[0].gameObject.SetActive(false);
        renderers[1].gameObject.SetActive(false);
        renderers[2].gameObject.SetActive(true);
    }
}
