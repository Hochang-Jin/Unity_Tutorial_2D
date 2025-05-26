using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        // this.transform.position += Vector3.forward;
    }

    void Update()
    {
        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키
        /// 점프 -> Space
        /// 총 쏘기 -> 마우스 좌클릭
        /// 등등..
        
        // 부드럽게 이동
        float h = Input.GetAxis("Horizontal"); // 값이 -1, 0, 1
        float v = Input.GetAxis("Vertical"); // 값이 -1, 0, 1
        
        // 딱 떨어지는 값
        // float h = Input.GetAxisRaw("Horizontal"); // 값이 -1, 0, 1
        // float v = Input.GetAxisRaw("Vertical"); // 값이 -1, 0, 1
        
        Vector3 dir = new Vector3(h, 0, v);
        // Debug.Log($"현재 입력 : {dir}");
        
        Vector3 normalDir = dir.normalized; // dir 정규화 (0~1)
        // 이동
        transform.position += normalDir * (speed * Time.deltaTime);
        // 회전
        transform.LookAt(transform.position + normalDir);
    }
}
