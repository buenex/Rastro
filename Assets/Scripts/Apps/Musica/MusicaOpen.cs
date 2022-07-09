using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicaOpen : MonoBehaviour
{
    [SerializeField]
    public AudioClip clip;
    [SerializeField]
    GameObject obj;
    [SerializeField]
    AudioSource source;
    [SerializeField]
    int index;
    // Start is called before the first frame update
    public void open()
    {
        source.volume = GameController.mus;
        source.clip = clip;        
        obj.GetComponentsInChildren<Text>()[0].text = GetComponentInChildren<Text>().text;
        obj.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite;
        obj.SetActive(true);
        obj.GetComponent<MusicSlider>().musicIndex = index;
    }
}
