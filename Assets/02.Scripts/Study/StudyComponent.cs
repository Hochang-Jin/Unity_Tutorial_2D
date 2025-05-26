using System;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    [SerializeField]
    private Transform objTransform;
    // public string changeName;
    
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Player"); // Main Camera 라는 이름의 오브젝트를 찾아서 obj에 대입
        objTransform = GameObject.FindGameObjectWithTag("Player").transform; // == obj.transform
        // obj.name = changeName;
        
        Debug.Log($"이름 : {obj.name}"); // 게임오브젝트의 이름
        Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
        Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기
        
        
        // MeshFilter 컴포넌트에 접근해서 mesh를 로그에 출력
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        // MeshRenderer 컴포넌트에 접근해서 material을 로그에 출력
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        
        
        // 로그 컬러링
        Debug.Log("<color=#ff00ff>Log Color Test</color>");
        
        
        // MeshRender 비활성화
        obj.GetComponent<MeshRenderer>().enabled = false;
        
        // obj의 GameObject 활성 상태를 false
        obj.SetActive(false);
    }
    
}
