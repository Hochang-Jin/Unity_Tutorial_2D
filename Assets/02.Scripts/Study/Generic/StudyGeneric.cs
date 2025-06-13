using UnityEngine;

public class StudyGeneric : MonoBehaviour
{
    void Start()
    {
        Factory<Monster> factory = new Factory<Monster>();
    }
}
