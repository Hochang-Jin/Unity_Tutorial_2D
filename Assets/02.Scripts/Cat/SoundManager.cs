using System;
using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip jumpClip;
        public AudioClip bgmClip;
        public AudioClip introClip;
        public AudioClip collisionClip;

        public void SetBGMSound(bool isIntro)
        {
            if (isIntro)
                audioSource.clip = introClip;
            else
                audioSource.clip = bgmClip;
            
            audioSource.loop = true;
            audioSource.volume = 0.12f;
            audioSource.Play();
        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }

        public void OnCollisionSound()
        {
            audioSource.PlayOneShot(collisionClip);
        }

        public void OnGameON()
        {
            
        }
        
        public void OnStartEvent()
        {
            audioSource.Stop();
            audioSource.clip = bgmClip;
            audioSource.Play();
        }
    }
}
