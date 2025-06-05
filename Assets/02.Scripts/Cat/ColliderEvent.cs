using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    public float speed = 5f;
    public GameObject fadeUI;
    
    void Update()
    {
        this.transform.position += Vector3.left*(speed * Time.deltaTime);
        if (this.transform.position.x < -12)
        {
            float rand = Random.Range(-8f, -5f);
            this.transform.position = new Vector3(12f, rand, 0f);
        }
    }

    // 상호 작용하는 둘 다 isTrigger = False면 호출
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);
        }
    }
}
