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
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        // Debug.Log($"현재 입력 : {dir}");
        
        transform.position += dir * (speed * Time.deltaTime);
        
    }
}
