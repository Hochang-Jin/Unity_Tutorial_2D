using System;
using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum CalculationType
    {
        PLUS, MINUS, MULTIPLY, DIVIDE
    } // 열거 타입 선언
    public CalculationType calculationType = CalculationType.PLUS;

    public int input1, input2, result;

    private void Start()
    {
        Calculation();
        Debug.Log($"계산 결과 : {result}");
    }

    private void Calculation()
    {
        switch (calculationType)
        {
            case CalculationType.PLUS:
                result = input1 + input2;
                break;
            case CalculationType.MINUS:
                result = input1 - input2;
                break;
            case CalculationType.MULTIPLY:
                result = input1 * input2;
                break;
            case CalculationType.DIVIDE:
                result = input1 / input2;
                break;
        }
    }
}
