using System;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    public PinBallManager pinBallManager;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        int tempScore = 0;
        
        switch (other.gameObject.tag)
        {
            
            case "Score10":
                tempScore = 10;
                break;
            case "Score30":
                tempScore = 30;
                break;
            case "Score50":
                tempScore = 50;
                break;
            default:
                return;
        }
        
        pinBallManager.score += tempScore;
        Debug.Log($"{tempScore}점 획득");
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"Score : {pinBallManager.score}");
        }
    }
}
