using System;
using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void Update()
    {
        
    }
}
