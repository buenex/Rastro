using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour
{
    [SerializeField]
    GameObject listaLetras;
    Transform[] letras = new Transform[26];

    public void Start()
    {
        for (int i = 0; i < 26; i++)
        {
            letras[i] = listaLetras.transform.GetChild(i);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (var item in letras)
        {
            if (item.name == collision.name)
            {
                item.GetComponent<Text>().fontSize = 54;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (var item in letras)
        {
            if (item.name == collision.name)
            {
                item.GetComponent<Text>().fontSize = 30;
            }
        }
    }
}
