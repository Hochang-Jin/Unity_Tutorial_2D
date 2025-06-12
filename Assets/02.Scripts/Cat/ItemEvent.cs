using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType {Pipe, Apple, Both}
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject apple;
    public GameObject particle;
    
    [SerializeField]
    private float moveSpeed;

    private float returnPosX = 12f;
    private float randomPosY;
    
    private float initPosX;

    private void Awake()
    {
        initPosX = transform.position.x;
    }

    private void OnEnable()
    {
        SetItem(initPosX);
    }

    void Update()
    {
        this.transform.position += Vector3.left*(moveSpeed * Time.deltaTime);
        if (this.transform.position.x < -12)
            SetItem(returnPosX);  // 위치 초기화
    }

    /// <summary>
    /// Item(pipe, apple, particle이 묶여있음)의 다음을 조정함
    /// 1. position
    /// 2. type ( pipe만 켜기, apple만 켜기, 둘다 켜기)
    /// </summary>
    /// <param name="posX"></param>
    private void SetItem(float posX)
    {
        // 일단 다 끄고 시작
        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);
        
        randomPosY = Random.Range(-8f, -6f);
        transform.position = new Vector3(posX, randomPosY, 0f);
        
        // 랜덤하게 타입을 만들어줌
        colliderType = (ColliderType)Random.Range(0, 3); // int -> ColliderType 으로 형변환(TypeCasting)
        
        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                break;
            case ColliderType.Apple:
                apple.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;
        }
    }
}
