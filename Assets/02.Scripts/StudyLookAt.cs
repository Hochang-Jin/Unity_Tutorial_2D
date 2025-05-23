using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf; // 어차피 position은 Transform에 있고, Transform은 GameObject에 무조건 있으니 그냥 Transform사용
    public Transform turretHead;
    
    public GameObject bulletPrefab;
    public Transform firePos; // 발사 위치

    public float timer;
    public float cooldownTime;
    
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() // 타겟을 바라보고 총알 발사
    {
        turretHead.LookAt(targetTf);
        
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
        
    }
}
