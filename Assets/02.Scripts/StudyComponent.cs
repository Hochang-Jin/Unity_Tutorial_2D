using System;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    public string changeName;
    
    void Start()
    {
        obj = GameObject.Find("Main Camera"); // Main Camera 라는 이름의 오브젝트를 찾아서 obj에 대입
        obj.name = changeName;
    }
}
