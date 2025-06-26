using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    private Vector3 offset;
    [SerializeField] private float smoothSpeed = 5f;
    
    [SerializeField] private Vector2 minBound, maxBound;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        Vector3 destination = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(this.transform.position, destination, Time.deltaTime * smoothSpeed);
        
        // 최대값과 최소값 보정
        smoothPos.x = Mathf.Clamp(smoothPos.x, minBound.x, maxBound.x);
        smoothPos.y = Mathf.Clamp(smoothPos.y, minBound.y, maxBound.y);
        
        this.transform.position = smoothPos;
    }
}
