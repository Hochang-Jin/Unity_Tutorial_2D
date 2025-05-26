using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
    
    
    void Update()
    {
        // 캐릭터가 월드 방향 앞으로 이동
        // transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        // transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime), Space.World);
        
        // 캐릭터가 로컬 방향 앞으로 이동
        // transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
        
        // 로컬 회전
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략
        // 월드 회전
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        
        // 주변을 회전
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
