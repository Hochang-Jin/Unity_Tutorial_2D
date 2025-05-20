using UnityEngine;

public class Study_Class
{
    public int number;

    public Study_Class(int number)
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
    
}

public class StudyClassStruct : MonoBehaviour
{
    void Start()
    {
        // 클래스와 구조체 비교
        Debug.Log("클래스 ----------------------------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1: {c1.number} / / c2: {c2.number}"); // c1: 10 / / c2: 10
        
        c1.number = 100;
        Debug.Log($"c1: {c1.number} / / c2: {c2.number}"); // c1: 100 / / c2: 100
        // c1과 c2는 같은 데이터를 참조하고 있음. c1에서 값을 바꾸어도 c2에서 같은 값이 나옴
        
        Debug.Log("구조체 ----------------------------------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1: {s1.number} / / s2: {s2.number}"); // s1: 10 / / s2: 10
        
        s1.number = 100;
        Debug.Log($"s1: {s1.number} / / s2: {s2.number}"); // s1: 100 / / s2: 10
        // s1과 s2는 메모리상 다른 데이터임. 따라서 s1에서 값을 바꾸면 s2는 바뀌지 않음
    }
}
