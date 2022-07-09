using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderFade : MonoBehaviour
{
    public Material shader;
    GameObject notification;

    public bool fade = false;
    // Start is called before the first frame update
    void Start()
    {
        shader.SetFloat("_Size", 3);
        if (notification != null)
        {
            notification = GameObject.FindGameObjectWithTag("countNotification");
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(shader.GetFloat("_Size"));

        if (fade)
        {
            if(shader.GetFloat("_Size")>0)
                shader.SetFloat("_Size", shader.GetFloat("_Size") - 0.1f);
            else
            {
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Entre no aplicativo 'Cortex' e escreva algo !", false);
                //GameObject.FindGameObjectWithTag("notification").SetActive(true);
                Destroy(this.gameObject);
            }
        }
    }
}
