using System;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;
    private SpriteRenderer sRenderer;

    public int dir = 1; // 방향 

    public abstract void Init();
    
    private void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        
        Init();
    }

    private void Update()
    {
        Move();
    }

    private void OnMouseDown()
    {
        Hit(1);
    }

    void Move()
    {
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

    void Hit(float damage)
    {
        hp -= damage;
        Debug.Log($"{this.name}가 {damage} 만큼 대미지를 받음.");
        Debug.Log($"{this.name}의 현재 hp : {hp}");

        if (hp <= 0)
        {
            Debug.Log($"{this.name} 죽음");
            Destroy(this.gameObject);
        }
    }
}