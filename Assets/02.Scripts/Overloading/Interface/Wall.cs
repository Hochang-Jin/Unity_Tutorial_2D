using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour, IDamageable
{
    public float hp;
    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage} damage");
        hp -= damage;
        
        if(hp <= 0)
            Death();
    }

    public void Death()
    {
        Debug.Log($"{gameObject.name} damage");
    }
}
