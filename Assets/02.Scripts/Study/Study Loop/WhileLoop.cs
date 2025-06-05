using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int count;
    void Start()
    {
        // while (count < 10)
        // {
        //     count++;
        //     Debug.Log($"현재 {count} 입니다.");
        // }

        // do
        // {
        //     count++;
        //     Debug.Log(count);
        // } 
        // while (count < 7);

        // while (count < 10)
        // {
        //     count++;
        //     Debug.Log(count);
        //     if(count == 5)
        //         break;
        // }
        
        while (count < 10)
        {
            count++;

            if (count == 5)
            {
                continue;
            }
            
            Debug.Log(count);
        }
    }
}
