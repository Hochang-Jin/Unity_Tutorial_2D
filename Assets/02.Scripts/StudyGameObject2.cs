using System;
using UnityEngine;

public class StudyGameObject2 : MonoBehaviour
{
    public GameObject prefab;
    
    void Start()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";
        
        Transform trans = obj.transform;
        int childCount = trans.childCount;
        
        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {childCount}");
        
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {trans.GetChild(0).name}");
        
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {trans.GetChild(childCount -1).name}");
    }
}