using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePannel;

    [SerializeField] private bool isFade = false;

    public void OnFade(float targetTime, Color color, bool isFadeStart = true)
    {
        StartCoroutine(Fade(targetTime, color,  isFadeStart));
    }
    
    public IEnumerator Fade(float targetTime, Color color, bool isFadeStart)
    { 
        float timer = 0f;
      
        
        while (timer <= targetTime)
        {
           
            float percent = timer / targetTime;
            
            float value = isFadeStart ? percent : 1 - percent; // isFade가 참이면 a값이 늘어나고, 거짓이면 줄어듬
            
            timer += Time.deltaTime;
            
            // timer를 이용해 targetTime초 동안 점점 a값을 올리는 기능
            fadePannel.color = new Color(color.r, color.g, color.b, value);
            yield return null;
        }
    }
}
