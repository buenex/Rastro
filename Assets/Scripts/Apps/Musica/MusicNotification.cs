using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicNotification : MonoBehaviour
{
    [SerializeField]
    AudioSource source;
    [SerializeField]
    Image img;
    void Update()
    {
        if (source.isPlaying)
        {
            img.enabled = true;
        }
        else
        {
            img.enabled = false ;
        }
    }
}
