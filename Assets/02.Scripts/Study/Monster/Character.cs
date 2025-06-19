using System;
using System.Collections;
using UnityEngine;

namespace MonsterInheritance
{
    public class Character : MonoBehaviour
    {
        private Animator animator;
        [SerializeField] private GameObject attackHitBox;
        
        [SerializeField] private float moveSpeed = 3f;
        
        private float h, v;
        private bool isAttack;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            Move();
            Attack();
        }


        void Move()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            if (h == 0 && v == 0) // Idle 상태 -> 움직이지 않는 상태 -> 어떠한 키도 누르지 않은 상태
            {
                animator.SetBool("isRunning", false);
            }
            else // Run 상태 -> 움직이는 상태 -> 어떠한 키 하나라도 누른 상태
            {
                animator.SetBool("isRunning", true);

                if (h > 0) // 우로 이동
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
                else if (h < 0) // 좌로 이동
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }


                var dir = new Vector3(h, v, 0).normalized;
                transform.position += dir * (moveSpeed * Time.deltaTime);
            }
        }

        void Attack()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(AttackRoutine());
            }
        }

        IEnumerator AttackRoutine()
        {
            isAttack = true;
            attackHitBox.SetActive(true);
            
            yield return new WaitForSeconds(0.24f);
            attackHitBox.SetActive(false);
            isAttack = false;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<Monster>() != null)
            {
                Monster montster = other.GetComponent<Monster>();
                // monster에게 hit 실행
                StartCoroutine(montster.Hit(1));
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.GetComponent<IItem>() != null)
            {
                IItem item = other.gameObject.GetComponent<IItem>();
                item.Get();
            }
        }
    }
}
