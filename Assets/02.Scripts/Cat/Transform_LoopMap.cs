using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    void Update()
    {
        this.transform.position += Vector3.left*(moveSpeed * Time.deltaTime);
        if (this.transform.position.x < -12)
        {
            float rand = Random.Range(-8f, -5f);
            this.transform.position = new Vector3(12f, rand, 0f);
        }
    }
}
