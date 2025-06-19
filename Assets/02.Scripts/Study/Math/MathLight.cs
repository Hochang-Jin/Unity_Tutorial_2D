using UnityEngine;

public class MathLight : MonoBehaviour
{
    private Light light;
    private float theta;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {
        theta += Time.deltaTime;

        // light.intensity = Mathf.Sin(theta);
        light.intensity = Mathf.PerlinNoise(theta, 0);
    }
}
