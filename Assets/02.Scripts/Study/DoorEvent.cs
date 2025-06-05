using System;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private string openKey;
    [SerializeField] private string closeKey;
    public GameObject doorlock;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // if(other.CompareTag("Player"))
        //     animator.SetTrigger(openKey);
        doorlock.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        doorlock.SetActive(false);
        animator.SetTrigger(closeKey);
    }
}
