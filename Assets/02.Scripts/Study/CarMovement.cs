using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D carRB;
    private float h;
    
    
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        
        // transform 이동
        // transform.position += Vector3.right * (h * moveSpeed * Time.deltaTime);
        
    }

    private void FixedUpdate()
    {
        // Rigidbody 이동
        carRB.linearVelocityX = h * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("CollisionEnter");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("CollisionStay");
    }
}
