using System;
using UnityEngine;

public class WirelessEarPhone : EarPhone
{
    public float batterySize;
    public bool isWirelessCharged;

    public void Charged()
    {
        string msg = isWirelessCharged ? "무선 충전" : "유선 충전";
        Debug.Log(msg);
    }

    private void Start()
    {
        name = "AirPod1";
        price = 13000;
        releaseYear = 2021;
        isWirelessCharged = false;
    }
}
