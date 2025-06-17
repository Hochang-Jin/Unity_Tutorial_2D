using UnityEngine;
using UnityEngine.PlayerLoop;


public class FlyingEye : Monster
{
    public override void Init()
    {
        hp = 4f;
        moveSpeed = 10f;
    }
}