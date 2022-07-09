using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountNotification : MonoBehaviour
{
    [SerializeField]
    GameObject count,countCortex;
    [SerializeField]
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (Notification.notifics.Count > 0)
        {
            count.SetActive(true);
            countCortex.SetActive(true);
        }
        else
        {
            count.SetActive(false);
            countCortex.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = Notification.notifics.Count.ToString();
    }
}
