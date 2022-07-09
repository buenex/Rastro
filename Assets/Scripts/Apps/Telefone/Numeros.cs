using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numeros : MonoBehaviour
{
    [SerializeField]
    Text txt;
    AudioSource source;
    [SerializeField]
    AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void returnName()
    {
        if (txt.text.Length < 12)
        {
            txt.text += this.gameObject.name;
            source.PlayOneShot(clip);
        }
    }

    public void removeNumber()
    {
        txt.text = txt.text.Remove(txt.text.Length-1,1);
    }
    public void mudaCor()
    {
        
    }
}
