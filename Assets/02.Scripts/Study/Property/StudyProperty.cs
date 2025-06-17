using System;
using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    private float moveSpeed = 29f;
    
    [SerializeField] private float moveSpeed2 = 29f;
    
    private float moveSpeed3 = 29f;
    public float MoveSpeed3
    {
        get;
        set;
    }
    
    [field: SerializeField]
    [Space(10)]
    [Header("속도")]
    [Range(0,10)]
    private float moveSpeed4 = 5f;
    public float MoveSpeed4 { get; set; }
    
    [HideInInspector]
    public float moveSpeed5 = 15f;
}
