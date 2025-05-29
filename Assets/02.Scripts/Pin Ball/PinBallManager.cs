using UnityEngine;

public class PinBallManager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;
    public Transform ballT;
    public Rigidbody2D ballRB;
    public int score;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ballT.position = new Vector3(0, 4, 0);
            ballRB.linearVelocity = Vector3.zero;
            ballRB.angularVelocity = 0;
            score = 0;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 회전력 
            leftBarRb.AddTorque(30f);
        }
        else
        {
            leftBarRb.AddTorque(-25f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightBarRb.AddTorque(-30f);
        }
        else
        {
            rightBarRb.AddTorque(25f);
        }
    }
}
