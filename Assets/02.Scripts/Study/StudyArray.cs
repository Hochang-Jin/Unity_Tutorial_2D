using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    // array와 list 공부
    public int[] arrayNumber = new int[5]{1,2,3,4,5};
    public List<int> listNumber = new List<int>();

    // field 공부
    int number1; // 기본값 private라 unity 에디터에 안나옴
    private int number2; // private라 unity 에디터에 안나옴
    
    public int number3; // public은 unity 에디터에서 보임
    [SerializeField]
    private int number4; // private이지만 SerializeField에 있으면 unity 에디터에서 보임
    [SerializeField] int number5; // private이지만 SerializeField에 있으면 unity 에디터에서 보임
    
    void Start()
    {
        // arrayNumber <- {1, 2, 3, 4, 5}
        Debug.Log($"arrayNumber[0] : {arrayNumber[0]}"); // arrayNumber[0] : 1
        Debug.Log($"arrayNumber[2] : {arrayNumber[2]}"); // arrayNumber[2] : 3 
        // Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}"); // IndexOutOfRangeException 
        
        Debug.Log($"현재 Array에 있는 데이터 수 : {arrayNumber.Length}"); // 현재 Array에 있는 데이터 수 : 5
        
        // listNumber 
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);
        // listNumber <- {1, 2, 3, 4, 5}
        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}"); // 현재 List에 있는 데이터 수 : 5
        
        Debug.Log($"마지막 데이터 : {listNumber[listNumber.Count - 1]}"); // ==listNumber[^1]
    }
}
