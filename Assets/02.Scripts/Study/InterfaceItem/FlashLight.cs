using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;
    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
    public void Use()
    {
        lightObj.SetActive(!lightObj.activeSelf);
    }
    public void Drop()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.SetParent(null);
    }
}
