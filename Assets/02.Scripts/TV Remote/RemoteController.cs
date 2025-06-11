using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    private VideoPlayer videoPlayer;
    public Button[] buttons;
    public GameObject muteIMG;
    public TextMeshProUGUI channel;
    
    public bool isOn = false;
    public bool isMute = false;

    public VideoClip[]  videoClips;
    
    [SerializeField]
    private int videoIndex = 0;
    
    private void Start()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        
        buttons[0].onClick.AddListener(OnScreenPower); // power 
        buttons[1].onClick.AddListener(OnMute); // mute
        buttons[2].onClick.AddListener(ChannelLeft); // channel left
        buttons[3].onClick.AddListener(ChannelRight); // channel right
        
        if (videoClips.Length == 0)
            return;
        videoPlayer.clip = videoClips[0];
    }

    public void OnScreenPower()
    {
        if(videoClips.Length == 0)
            return;
        
        isOn = !isOn;
        videoScreen.SetActive(isOn);

        if (isOn)
        {
            muteIMG.SetActive(isMute);
            channel.gameObject.SetActive(true);
        }
        else
        {
            muteIMG.SetActive(false);
            channel.gameObject.SetActive(false);
        }
    }

    public void OnMute()
    {
        if(!isOn)
            return;
        
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute);
        
        muteIMG.SetActive(isMute);
    }

    void ChannelLeft()
    {
        if(!isOn)
            return;
        if(videoClips.Length <= 1)
            return;
        
        if(videoIndex > 0)
            videoPlayer.clip = videoClips[--videoIndex];
        else
        {
            videoIndex = videoClips.Length - 1;
            videoPlayer.clip = videoClips[videoIndex];
        }

        channel.text = $"CH. {videoIndex + 1}";
    }
    
    public void ChannelRight()
    {
        if(!isOn)
            return;
        if(videoClips.Length <= 1)
            return;
        
        if (videoIndex < videoClips.Length - 1)
        {
            videoPlayer.clip = videoClips[++videoIndex];
        }
        else
        {
            videoIndex = 0;
            videoPlayer.clip = videoClips[videoIndex];
        }
        
        channel.text = $"CH. {videoIndex + 1}";
    }
}
