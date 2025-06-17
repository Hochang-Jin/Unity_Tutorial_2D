using UnityEngine;

public class Gun : MonoBehaviour, IDropItem
{
    public GameObject Bullet;
    public Transform firePos;
    
    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

    }
    public void Use()
    {
        GameObject bullet = Instantiate(Bullet, firePos.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePos.forward * 100f, ForceMode.Impulse);
        
        Destroy(bullet, 3f);
    }
    public void Drop()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.SetParent(null);
    }
}
