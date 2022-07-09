using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    [SerializeField]
    GameObject video;
    VideoPlayer vid;
    [SerializeField]
    Image img;
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
        if (Time.time > tim+1)
        {
            img.color -= new Color(0, 0, 0, .01f);
            if (!vid.isPlaying)
            {
                SceneManager.LoadScene("Intro");
            }
        }
    }
}
