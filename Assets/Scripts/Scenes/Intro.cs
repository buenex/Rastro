using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Intro : MonoBehaviour
{
    [SerializeField]
    GameObject video;
    VideoPlayer vid;
    float tim;

    private void Awake()
    {
        vid = video.GetComponent<VideoPlayer>();
    }

    private void Start()
    {
        tim = Time.time;
    }

    void FixedUpdate()
    {
        if (Time.time > tim+2)
        {
            if (!vid.isPlaying)
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
}
