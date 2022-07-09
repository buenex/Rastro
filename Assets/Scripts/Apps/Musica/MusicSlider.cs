using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    [SerializeField]
    Slider sld;
    [SerializeField]
    AudioSource source;
    [SerializeField]
    Image album;
    [SerializeField]
    Text name;

    [SerializeField]
    GameObject ply, paus,content;
    MusicaOpen[] musics;
    [SerializeField]
    Sprite[] images;
    Text[] names;
    public int musicIndex;
    private void Start()
    {
        musics = content.GetComponentsInChildren<MusicaOpen>();
        names = content.GetComponentsInChildren<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        float time = source.clip.length;
        sld.value = source.time/ time;
        
        if(source.isPlaying)
        {
            paus.SetActive(true);
            ply.SetActive(false);
        }
        else
        {
            paus.SetActive(false);
            ply.SetActive(true);
        }
    }
    public void play()
    {
        paus.SetActive(true);
        ply.SetActive(false);
        if (sld.value>0)
            source.UnPause();
        else
            source.Play();

    }

    public void pause()
    {
        paus.SetActive(false);
        ply.SetActive(true);
        source.Pause();
    }

    public void setMusic(bool next)
    {
        if(next)
        {
            if (musicIndex == musics.Length - 1)
                musicIndex = 0;
            else
                musicIndex++;
        }
        else if(!next)
        {
            if (musicIndex == 0)
                musicIndex = musics.Length-1;
            else
                musicIndex--;
        }
        source.clip = musics[musicIndex].clip;
        album.sprite = images[musicIndex];
        name.text = names[musicIndex].text;
        source.Play();
    }
 
}

