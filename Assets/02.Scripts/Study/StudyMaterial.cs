using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    
    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material을 바꾸는 방식X
        
        this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer에 접근해서 바꿔야함
        
        // this.GetComponent<MeshRenderer>().sharedMaterial = mat;
        
        // this.GetComponent<MeshRenderer>().material.color = Color.cyan;
        
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.cyan;
    }
    
}
