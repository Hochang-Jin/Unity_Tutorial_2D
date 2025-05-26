using UnityEngine;

public class StudyComponent2MakeCube : MonoBehaviour
{
    public GameObject obj;

    public Mesh mesh;
    public Material material;
    void Start()
    {
        CreateCube("Cube Name");
        CreateCube();
    }
    

    public void CreateCube(string name = "Cube")
    {
        // Cube 라는 이름의 빈 게임오브젝트 생성
        obj = new GameObject(name);
        
        // 컴포넌트 추가
        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<BoxCollider>();

        // 컴포넌트에 속성 추가
        obj.GetComponent<MeshFilter>().mesh = mesh;
        obj.GetComponent<MeshRenderer>().material = material;
    }
}
