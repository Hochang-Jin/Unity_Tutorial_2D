using System;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private string openKey;
    [SerializeField] private string closeKey;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            animator.SetTrigger(openKey);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetTrigger(closeKey);
    }
}
