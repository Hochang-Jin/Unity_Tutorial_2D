using System;
using UnityEngine;

public class StudyLog : MonoBehaviour
{
    void Start()
    {
        // 시작 시 한 번만 로그를 띄움
        Debug.Log("START"); // 일반 로그
        Debug.LogWarning("START"); // 경고 로그
        Debug.LogError("START"); // 에러 로그
    }

    void Update()
    {
        // 프로그램 실행 중 매 프레임 마다 로그를 띄움
        Debug.Log("UPDATE"); 
    }
}