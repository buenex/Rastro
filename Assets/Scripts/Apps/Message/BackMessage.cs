using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMessage : MonoBehaviour
{
    [SerializeField]
    GameObject message, itemMessage;

    public void back()
    {
        itemMessage.SetActive(false);
        message.SetActive(false);
    }
}
