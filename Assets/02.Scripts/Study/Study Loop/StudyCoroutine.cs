using System;
using System.Collections;
using UnityEngine;

public class StudyCoroutine : MonoBehaviour
{
    private Coroutine coroutine;
    void Start()
    {
        Debug.Log("Start");
        
        coroutine = StartCoroutine(RoutineA()); // 코루틴을 변수에 담아서 사용
        
        Invoke("StopRoutine", 6f);
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    IEnumerator RoutineA()
    {
        // 코루틴 필수 yield return ... 
        yield return new WaitForSeconds(3f); // 3초 대기
        Debug.Log("hello");
        
        yield return new WaitForSeconds(2f); // 3초 대기
        Debug.Log("world");
        
        yield return new WaitForSeconds(2f); // 3초 대기
        Debug.Log("paradise");
    }

    void StopRoutine()
    {
        StopCoroutine(coroutine);
        Debug.Log("StopRoutine");
    }
}
