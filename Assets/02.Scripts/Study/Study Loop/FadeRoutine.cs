using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePannel;
    private float timer = 0f;
    public float targetTime = 3f;

    [SerializeField] private bool isFade = false;

    IEnumerator Start()
    {
        while (timer <= targetTime)
        {
            float percent = timer / targetTime;
            float value = isFade ? percent : 1 - percent; // isFade가 참이면 a값이 늘어나고, 거짓이면 줄어듬
            timer += Time.deltaTime;
            // timer를 이용해 targetTime초 동안 점점 a값을 올리는 기능
            fadePannel.color = new Color(fadePannel.color.r, fadePannel.color.g, fadePannel.color.b, value);
            yield return null;
        }
    }


    IEnumerator fade()
    {
        while (timer <= targetTime)
        {
            timer += Time.deltaTime;
            // timer를 이용해 targetTime초 동안 점점 a값을 올리는 기능
            fadePannel.color =
                new Color(fadePannel.color.r, fadePannel.color.g, fadePannel.color.b, timer / targetTime);
            yield return null;
        }
    }

    IEnumerator Unfade()
    {
        while (timer <= targetTime)
        {
            timer += Time.deltaTime;
            // timer를 이용해 targetTime초 동안 점점 a값을 내리는 기능
            fadePannel.color = new Color(fadePannel.color.r, fadePannel.color.g, fadePannel.color.b,
                1 - timer / targetTime);
            yield return null;
        }
    }
}
