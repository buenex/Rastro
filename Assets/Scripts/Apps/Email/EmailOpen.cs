using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailOpen : MonoBehaviour
{
    [SerializeField]
    GameObject email;
    [SerializeField]
    bool governamental,mission;


    public void openEmail(GameObject window)
    {
        window.SetActive(true);
        if (mission)
        {
            window.GetComponentsInChildren<Button>()[1].enabled=true;
        }
        else
        {
            window.GetComponentsInChildren<Button>()[1].enabled = false;
        }
    }

    public void setEmail(GameObject email)
    {
        string mail = "@mail.com";
        email.GetComponentsInChildren<Text>()[0].text = this.GetComponentsInChildren<Text>()[0].text;
        if (governamental)
            mail = "@gov.a.com";
        email.GetComponentsInChildren<Text>()[1].text = this.GetComponentsInChildren<Text>()[0].text.Replace(" ","")+mail;
        email.GetComponentsInChildren<Text>()[2].text = this.GetComponentsInChildren<Text>()[1].text;
    }
}
