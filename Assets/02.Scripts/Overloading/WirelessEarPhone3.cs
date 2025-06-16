using Unity.VisualScripting;
using UnityEngine;

public class WirelessEarPhone3 : WirelessEarPhone2
{
    public enum NoiseCancelType
    {
        Off,
        On,
        Around
    };
    public NoiseCancelType noiseCancelType;

    void Start()
    {
        name = "Airpod3";
        price = 13000;
        releaseYear = 2021;
        isWirelessCharged = false;
        isNoiseCanceling = false;
        noiseCancelType = NoiseCancelType.Off;
    }
    public void SetNoiseCancelType(NoiseCancelType noiseCancelType)
    {
        this.noiseCancelType = noiseCancelType;
    }
    
    public override void NoiseCanceling()
    {
        SetNoiseCancelType(noiseCancelType);
        
        base.NoiseCanceling();
    }
    
}
