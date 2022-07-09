using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DateTime : MonoBehaviour
{
    [SerializeField]
    Text dateTime,dateString;
    // Start is called before the first frame update
    void Start()
    {
        dateString.text = System.DateTime.Now.ToLongDateString();
    }

    // Update is called once per frame
    void Update()
    {
        dateTime.text = System.DateTime.Now.ToShortTimeString();
    }
}
