using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class LottoGenerator : MonoBehaviour
{
    // public int[] intArray = new int[10]; // 배열은 미리 만들어 놓는 방식
    public List<int> intList = new List<int>(); // 필요할 때마다 추가 / 삭제 / 삽입 가능한 방식

    public int shakeCount = 10000;

    public Button button;
    public TextMeshProUGUI[] texts;
    
    void Awake()
    {
        for (int i = 1; i < 46; i++) // i = 1 ~ 45까지의 반복
        {
            intList.Add(i);
        }
    }

    private void Start()
    {
        button.onClick.AddListener(OnBtn);
    }

    public void OnBtn()
    {
        for (int i = 0; i < shakeCount; i++)
        {
            int ranInt1 = Random.Range(0, intList.Count);
            int ranInt2 = Random.Range(0, intList.Count);

            var temp = intList[ranInt1];
            intList[ranInt1] = intList[ranInt2];
            intList[ranInt2] = temp;
        }
        List<int> resultList = new List<int>();
        for (int i = 0; i < 6; i++)
            resultList.Add(intList[i]);
        resultList.Sort();

        for (int i = 0; i < 6; i++)
        {
            texts[i].text = resultList[i].ToString();
        }
        
    }
}