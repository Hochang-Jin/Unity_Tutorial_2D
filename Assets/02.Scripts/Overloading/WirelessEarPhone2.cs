using UnityEngine;

public class WirelessEarPhone2 : WirelessEarPhone
{
    public bool isNoiseCanceling;
    
    public virtual void NoiseCanceling()
    {
        isNoiseCanceling = !isNoiseCanceling;

        string msg = isNoiseCanceling ? "노이즈 캔슬링 On" : "노이즈 캔슬링 Off";
        Debug.Log(msg);
    }

    void Start()
    {
        name = "Airpod2";
        price = 13000;
        releaseYear = 2021;
        isWirelessCharged = true;
        isNoiseCanceling = true;
    }
}
