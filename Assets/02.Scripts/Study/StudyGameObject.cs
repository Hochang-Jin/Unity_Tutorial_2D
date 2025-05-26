using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    public GameObject destroyObj;
    
    
    public Vector3 pos;
    public Quaternion rot;
    
    void Start()
    {
        CreateAmongUS();
        
        Destroy(destroyObj, 3f); // 실행 후 3초뒤에 파괴하는 기능
        
        Destroy(this.gameObject, 5f); // 이 코드를 실행한 오브젝트를 5초 뒤에 파괴하는 기능
        
    }
    
    void OnDestroy()
    {
        Debug.Log("파괴되었습니다.");
    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하고 이름을 변경하는 기능
    /// </summary>
    public void CreateAmongUS()
    {
      
        //생성할 데이터, 위치, 회전
        GameObject obj = Instantiate(prefab, pos, rot); // GameObject를 생성하는 기능
        Debug.Log("생성되었습니다.");
        obj.name = "어몽어수 캐뤽퉈";
    }
}
