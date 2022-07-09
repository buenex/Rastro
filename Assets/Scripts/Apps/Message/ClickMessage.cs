using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMessage : MonoBehaviour
{
    [SerializeField]
    GameObject message, itemMessage;

    public  void open()
    {
        message.SetActive(true);
        itemMessage.SetActive(true);
    }
}
