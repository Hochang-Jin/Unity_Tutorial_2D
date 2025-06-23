using UnityEngine;

public class MathCross : MonoBehaviour
{
    public Vector3 vecA = Vector3.right;
    public Vector3 vecB = Vector3.up;
    void Start()
    {
        Vector3 result = Vector3.Cross(vecA, vecB);
        
        Debug.Log($"벡터의 외적 :  {result}");

    }
}
