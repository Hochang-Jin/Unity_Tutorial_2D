using UnityEngine;
using UnityEngine.PlayerLoop;


public class FlyingEye : Monster
{
    public override void Init()
    {
        hp = 1f;
        moveSpeed = 10f;
    }
}