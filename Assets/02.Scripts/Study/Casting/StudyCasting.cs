using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyCasting : MonoBehaviour
{
    List<Orc> orcs =  new List<Orc>();
    List<Goblin> goblins = new List<Goblin>();
    
    List<Monster> monsters = new List<Monster>();
    
    void Start()
    {
        Orc o = new Orc();
        Goblin g = new Goblin();
        
        // upcasting
        // 명시적
        Monster m1 = (Monster)o;
        Monster m2 = (Monster)g;
        
        // 암시적
        Monster m3 = o;
        Monster m4 = g;
        
        // downcasting
        Monster m5 = new Monster();
        Orc orc = (Orc)m5;
    }
}