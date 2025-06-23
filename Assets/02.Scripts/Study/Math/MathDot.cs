using UnityEngine;

public class MathDot : MonoBehaviour
{
    public Vector3 vecA = new Vector3(1,0,0);
    public Vector3 vecB = new Vector3(0,1,0);
    
    void Start()
    {
        float dot = Vector3.Dot(vecA, vecB);
        float angle = Vector3.Angle(vecA, vecB);
        
        Debug.Log($"벡터의 내적 : {dot}");
        Debug.Log($"벡터의 각도 : {angle}");
    }
}
