using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public enum sound {notification=0 ,message=1};
    [SerializeField]
    AudioClip[] sounds;
    AudioSource aud;

    void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    
    public void playClip(sound snd)
    {
        aud.volume = GameController.ef;
        aud.PlayOneShot(sounds[(int)snd]);
    }
}
