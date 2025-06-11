using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

namespace Cat
{
    public class VideoManager : MonoBehaviour
    {
        public GameObject videoPanel;

        public VideoPlayer videoPlayer;
        public VideoClip[] videoClips;

        private void Start()
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            videoPanel.SetActive(true);

            var clip = isHappy ? videoClips[0] : videoClips[1];
            videoPlayer.clip = clip;
            videoPlayer.Play();
        }
    }
}


