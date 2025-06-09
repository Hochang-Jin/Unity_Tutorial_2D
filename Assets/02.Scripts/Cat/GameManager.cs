using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTimeUI;
    private float timer;
    void Update()
    {
        timer += Time.deltaTime;
        // 0 <- 뒤의 매개변수중 첫번째 거 가져온다
        // :f1 소숫점 한자리까지 가져온다
        playTimeUI.text = string.Format("플레이 시간 : {0:f1}초", timer);
    }
}