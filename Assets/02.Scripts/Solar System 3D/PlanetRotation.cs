using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotateSpeed = 30f; // 자전 속도
    public float revolutionSpeed = 20f; // 공전 속도
    public bool isRevolution = false; // 공전 기능
    void Update()
    {
        transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
        if(isRevolution)
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
    }
}
