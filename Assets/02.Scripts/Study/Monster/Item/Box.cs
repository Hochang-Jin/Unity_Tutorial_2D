using System;
using UnityEngine;

public class Box : MonoBehaviour, IItem
{
    private Inventory inventory;
    public GameObject Obj { get; set; }
    private void OnMouseDown()
    {
        Get();
    }

    public void Get()
    {
        Debug.Log($"{this.name} 획득");
        gameObject.SetActive(false);
        inventory.AddItem(this);
    }

    private void Start()
    {
        Obj = gameObject;
        inventory = FindFirstObjectByType<Inventory>();
    }
}
