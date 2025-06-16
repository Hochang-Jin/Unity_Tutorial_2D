using UnityEngine;

// Player
public class StudyOverloading : MonoBehaviour
{
    void Start()
    {
        Attack( );
        Attack(true);
        Attack(178);
        Attack(178, new GameObject("몬스터"));
    }

    public void Attack()
    {
        Debug.Log("공격");
    }

    public void Attack(bool isMagic)
    {
        if(isMagic)
            Debug.Log("마법 공격");
    }

    public void Attack(float damage)
    {
        Debug.Log($"{damage} 만큼 공격");
    }

    public void Attack(float damage, GameObject target)
    {
        Debug.Log($"{target.name} 에게 {damage} 만큼 공격");
    }
}
