using System;
using UnityEngine;

public class StudyInvoke : MonoBehaviour
{
    public float timer = 3f;
    void Start()
    {
        Debug.Log("시작 시간");
        // Invoke("Method1", timer);
        //
        // CancelInvoke("Method1");
        InvokeRepeating("Method1", timer, 1f);
        // (함수명, 처음 지연시간, 몇초마다 실행)
    }

    private void OnDestroy()
    {
        Debug.Log("파괴됨");
    }

    private void Update()
    {		    
        // 스페이스바 누르면 CancelInvoke
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Method1");
            Debug.Log("스페이스바 입력됨");
        }
    }

    private void Method1()
    {
        Debug.Log("Method1");
    }
}
