using System;
using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;
    private Spawner spawner;
    
    private SpriteRenderer sRenderer;
    private Animator animator;

    public int dir = 1; // 방향 
    private bool isMoving = true;
    private bool isHit = false;

    public abstract void Init();
    
    private void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        spawner = FindFirstObjectByType<Spawner>();
        
        Init();
    }

    private void Update()
    {
        Move();
    }

    private void OnMouseDown()
    {
        StartCoroutine(Hit(1));
    }

    void Move()
    {
        if(!isMoving) return;
        
        transform.position += Vector3.right * (dir * moveSpeed * Time.deltaTime);
        if (this.transform.position.x > 8f)
        {
            dir = -1;
            sRenderer.flipX = true;
        }
        else if (this.transform.position.x < -8f)
        {
            dir = 1;
            sRenderer.flipX = false;
        }
    }

    public IEnumerator Hit(float damage)
    {  
        if (isHit)
            yield break;
        
        isMoving = false;
        isHit = true;
        hp -= damage;
      
        animator.SetTrigger("Hit");

        if (hp <= 0)
        {
            animator.SetTrigger("Death");
            isMoving = false;
            isHit = true;
            spawner.DropCoin(this.transform.position);
            
            yield return new WaitForSeconds(2f);
            this.gameObject.SetActive(false);
            yield break;
        }
        yield return new WaitForSeconds(0.5f);
        isMoving = true;
        isHit = false;
    }
    
}