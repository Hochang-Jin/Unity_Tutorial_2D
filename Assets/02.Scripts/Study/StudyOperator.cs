using UnityEngine;

public class StudyOperator : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;
    void Start()
    {
        bool isMax = currentLevel >= maxLevel;
        string text = isMax ? "맞습니다." : "아닙니다.";
        Debug.Log($"현재 레벨은 만렙이 {text}");
    }
}
