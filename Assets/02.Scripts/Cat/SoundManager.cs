using System;
using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        private AudioSource audioSource;
        [SerializeField]
        private AudioClip jumpClip;
        [SerializeField]
        private AudioClip bgmClip;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
            
            audioSource.clip = bgmClip;
            audioSource.playOnAwake = true;
            audioSource.loop = true;
            audioSource.volume = 0.12f;
            audioSource.Play();
        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }
    }
}
