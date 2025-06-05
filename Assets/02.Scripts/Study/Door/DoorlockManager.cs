using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DoorlockManager : MonoBehaviour
{
    public string inputPassword; // 입력 받을 패스워드
    const string password = "123456"; // 정답 패스워드
    public TextMeshProUGUI passwordTextUI; // 입력중인 패스워드 보여줄 텍스트
    public Image passwordImageUI; // 정답인지 아닌지 색상으로 알려줄 것
    // 패스워드 길이 제한
    private int numCount = 0; 
    private const int MAXNUM = 6;
    // UI ON OFF
    public GameObject doorlock;
    // 문 애니메이터
    public Animator doorOpenAnim;

    /// <summary>
    /// 버튼 눌렀을 때 실행할 함수
    /// </summary>
    /// <param name="text"></param>
    public void OnButtonClick(string text)
    {
        // 버튼 누르면 일단 정답지 색을 원래대로 되돌림
        passwordImageUI.color = Color.white;
        if (text == "Enter") // 정답 확인 하는 Enter 눌렀을 때
        {
            if (password == inputPassword) // 정답이면
            {
                inputPassword = "";
                numCount = 0;
                passwordImageUI.color = Color.green;
                doorlock.SetActive(false);
                doorOpenAnim.SetTrigger("DoorOpen");
            }
            else // 틀렸을 때
            {
                inputPassword = "";
                numCount = 0;
                passwordImageUI.color = Color.red;
            }
        }
        else if (text == "Clear") // 지우는 버튼
        {
            inputPassword = "";
            numCount = 0;
        }
        else // 다른 숫자 버튼을 눌렀을 때
        {
            if(numCount == MAXNUM)
                return;
            inputPassword += text;
            numCount++;
        }
        
        passwordTextUI.text = inputPassword; 
    }
}
