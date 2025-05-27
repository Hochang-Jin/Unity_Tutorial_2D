using System;
using UnityEngine;

public class Material_LoopMap : MonoBehaviour
{ 
    [SerializeField]
    private float moveSpeed = 3f;
    private MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 offset = Vector2.right * (moveSpeed * Time.deltaTime);
        
        meshRenderer.material.SetTextureOffset("_MainTex", meshRenderer.material.mainTextureOffset + offset);
    }
}
