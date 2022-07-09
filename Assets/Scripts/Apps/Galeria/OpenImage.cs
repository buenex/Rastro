using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenImage : MonoBehaviour
{
    [SerializeField]
    Image img;
    [SerializeField]
    GameObject openImage;
    
    public void insertAndOpenImage()
    {
        img.sprite = GetComponent<Image>().sprite;
        openImage.SetActive(true);
    }
}
