using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyCasting : MonoBehaviour
{
    List<Goblin> goblins = new List<Goblin>();
    
    List<Monster> monsters = new List<Monster>();
    
    void Start()
    {
        Goblin g = new Goblin();
        
        // upcasting
        // 명시적
        // Monster m2 = (Monster)g;
        
        // 암시적
        // Monster m4 = g;
        
        // downcasting
    }
}