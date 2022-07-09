using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handle : MonoBehaviour
{
    [SerializeField]
    Slider sld;
    bool up,voltar;
    [SerializeField]
    GameObject open,close;
    [SerializeField]
    ShaderFade script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        if (voltar)
        {
            //Debug.Log("voltar");
            sld.value -= 0.08f;
            if (sld.value < 0.05f)
            {
                voltar = false;
            }
        }
    }
    private void OnMouseUp()
    {
       //Debug.Log("soltou");
        //up = true;
        if (sld.value == 1)
        {
            open.SetActive(true);
            script.fade = true;
            close.SetActive(false);
        }
        else
        {
            //Debug.Log("Up");
            voltar = true;
            //sld.value = 0;
        }
    }
}
