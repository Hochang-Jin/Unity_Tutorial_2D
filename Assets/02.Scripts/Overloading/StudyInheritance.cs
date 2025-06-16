using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StudyInheritance : MonoBehaviour
{
    public List<Person> people = new List<Person>();
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            Soldier soldier = new Soldier();
            
            people.Add(student);
            people.Add(soldier);
        }
    }

    public void AllMove()
    {
        foreach(Person person in people)
            person.Walk();
    }
}
