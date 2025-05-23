using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position += transform.forward * (bulletSpeed * Time.deltaTime);
    }
}
