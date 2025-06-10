using UnityEngine;

public class ColliderEvent : MonoBehaviour
{

    public GameObject fadeUI;

    // 상호 작용하는 둘 다 isTrigger = False면 호출
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);
        }
    }
}
