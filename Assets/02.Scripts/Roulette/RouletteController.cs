using System;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    private bool isStop = false;

    private void Start()
    {
        rotSpeed = 0f;
    }

    // 룰렛을 계속 돌릴거니까 Update에서 코드 작성
    void Update()
    {
        // Z축 방향으로 회전
        transform.Rotate(Vector3.back * rotSpeed);
        // == transform.Rotate(0f, 0f, rotSpeed);

        // 마우스 왼쪽 누르면 회전
        if (Input.GetMouseButtonDown(0) && !isStop)
        {
            rotSpeed = 5f;
        }

        // 스페이스 버튼을 눌렀을 때 멈추게 함
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 멈추게 하기 위한 bool 변수를 켜줌
            isStop = true;
        }
        
        // 멈춰야 하면 (bool 변수가 true면) 속도를 0.98씩 곱해서 느려지게 함
        if (isStop)
        {
            rotSpeed *= 0.98f;
            // 어느정도 속도가 줄면 멈추게 하고 더이상 멈출 필요가 없으니 bool변수를 다시 꺼줌
            if (rotSpeed < 0.1f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }
    }
}
