using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    bool aberto;
    [SerializeField]
    Slider sld;
    [SerializeField]
    Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        aberto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sld.value == 1)
        {            
            aberto = true;
        }
        else
        {
            aberto = false;
        }
        //if (aberto)
        //{
        //    anim.SetBool("aberto", true);
        //}
        //else
        //{
        //    anim.SetBool("aberto", false);
        //}
    }    
}
