using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject[] monsters;
    public GameObject[] items;
    public float spawnRate = 4f;
    
    // n초마다 몬스터를 랜덤으로 생성하는 기능

    IEnumerator Start()
    {
        while (true)
        {
            var randomIndex = Random.Range(0, monsters.Length);
            
            float randomX = Random.Range(-8f, 8f);
            float randomY = Random.Range(-3f, 5f);
            
            Instantiate(monsters[randomIndex],new Vector3(randomX, randomY, 0), Quaternion.identity);
            
            yield return new WaitForSeconds(spawnRate);
        }
    }

    public void DropCoin(Vector3 position)
    {
        var randomItem = Random.Range(0, items.Length);
        var dropItem = Instantiate(items[randomItem], position, Quaternion.identity);
        var dropItemRB = dropItem.GetComponent<Rigidbody2D>();
        var randomXPower =  Random.Range(-2f, 2f);
        
        dropItemRB.AddForceX(randomXPower, ForceMode2D.Impulse);
        dropItemRB.AddForceY(3f, ForceMode2D.Impulse);
        
    }
}
