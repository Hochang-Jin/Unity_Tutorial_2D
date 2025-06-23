using System;
using UnityEngine;

public class MathLerp : MonoBehaviour
{
    public Transform target;
    public float smoothValue;

    private Vector3 startPos;
    public float timer, percent, lerpTime;

    private void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // 기본 선형 이동
        // transform.position = Vector3.Lerp(transform.position, target.position, smoothValue);
        
        // 일정하게 이동
        timer += Time.deltaTime;
        percent = timer / lerpTime;
        transform.position = Vector3.Lerp(startPos, target.position, percent);
    }
}
