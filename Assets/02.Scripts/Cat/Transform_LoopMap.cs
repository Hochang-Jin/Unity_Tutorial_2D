using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime); // 배경 왼쪽으로 이동
        // transform.position += Vector3.left * (moveSpeed * Time.fixedDeltaTime); // 배경 왼쪽으로 이동
        
        // x 가 -30 보다 더 왼쪽으로 이동하게 될 경우 다시 오른쪽으로 돌려줌 (이미지의 길이가 30이라서 30임)
        if (transform.position.x < -30f)
            transform.position = new Vector3(transform.position.x + 60, transform.position.y, transform.position.z);
    }
}
