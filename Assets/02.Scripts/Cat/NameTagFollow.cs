using UnityEngine;

public class NameTagFollow : MonoBehaviour
{
    public Transform cat;
    void Update()
    {
        transform.position = cat.position + new Vector3(0.07f, 0.83f, 0f);
    }
}
