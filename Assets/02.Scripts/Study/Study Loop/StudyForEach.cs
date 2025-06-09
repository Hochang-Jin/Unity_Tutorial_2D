using System.Collections.Generic;
using UnityEngine;

public class StudyForEach : MonoBehaviour
{
    public string[] persons = new string[5] { "철수", "영희", "동수", "창섭", "원기" };
    // public List<string> personNames = new List<string>();

    public string findName;
    void Start()
    {
        // foreach (string person in persons)
        // {
        //     Debug.Log(person);
        // }
        //
        // foreach (string person in personNames)
        // {
        //     Debug.Log(person);
        // }

        FindPerson(findName);
        
    }

    private void FindPerson(string name)
    {
        foreach (string person in persons)
        {
            if (person == name)
            {
                Debug.Log("찾으시는 이름이 있읍니다.");
                return;
            }
        }
        Debug.Log($"{name}을 찾지 못했습니다.");
    }
}
