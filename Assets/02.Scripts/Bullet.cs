using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    private void Start()
    {
        Destroy(gameObject, 5f); // 5초 뒤 파괴
    }

    void Update()
    {
        transform.position += transform.forward * (bulletSpeed * Time.deltaTime);
    }
}
