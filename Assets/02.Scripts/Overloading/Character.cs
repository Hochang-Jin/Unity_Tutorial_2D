using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float hp;
    public float moveSpeed;

    private void Update()
    {
        Move();
    }

    public virtual void Attack()
    {
        Debug.Log("공격1");
        Debug.Log("공격2");
        Debug.Log("공격3");
        Debug.Log("공격4");
        Debug.Log("공격5");
    }

    public abstract void Move();


}
