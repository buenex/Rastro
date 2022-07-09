using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotasOpen : MonoBehaviour
{
    [SerializeField]
    GameObject nota;

    public void openNota(GameObject window)
    {
        window.SetActive(true);
    }

    public void setNota(GameObject nota)
    {
        nota.GetComponentsInChildren<Text>()[0].text = this.GetComponentsInChildren<Text>()[0].text;        
        nota.GetComponentsInChildren<Text>()[1].text = this.GetComponentsInChildren<Text>()[1].text;
    }
}