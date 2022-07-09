using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrumaLetras : MonoBehaviour
{
    [SerializeField]
    RectTransform[] letras;
    const float constante = 0.03846f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < letras.Length; i++)
        {
            if (i == 0)
            {
                letras[i].anchorMin = new Vector2(0,1 - constante);
                letras[i].anchorMax = new Vector2(1, 1);
                letras[i].right = new Vector3();
                letras[i].up = new Vector3();
                letras[i].forward = new Vector3();
            }
            else
            {
                letras[i].anchorMin = new Vector2(0, letras[i-1].anchorMin.y - constante);
                letras[i].anchorMax = new Vector2(1, letras[i - 1].anchorMax.y - constante);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 
