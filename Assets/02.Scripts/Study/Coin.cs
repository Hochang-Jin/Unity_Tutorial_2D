using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Movement.coinCount++;
            Debug.Log($"코인 획득 :  {Movement.coinCount}");
            
            Destroy(gameObject);
        }
    }
}
