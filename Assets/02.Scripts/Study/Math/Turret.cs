using System;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform turretHead;
    
    private float theta;
    private float speed = 2f;
    private float range = 60f;

    private bool isTarget;
    public Transform target;

    private void Update()
    {
        if (!isTarget)
            TurretIDLE();
        else
            LookTarget();
    }

    void TurretIDLE()
    {
        theta += Time.deltaTime * speed;
        float y = Mathf.Sin(theta) * range;
        
        turretHead.localRotation = Quaternion.Euler(0, y,0);
    }

    void LookTarget()
    {
        turretHead.LookAt(target);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = other.transform;
            isTarget = true;
        }
    }
}
