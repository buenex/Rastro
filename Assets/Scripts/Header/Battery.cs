using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    [SerializeField]
    Image fill;
    [SerializeField]
    int timeFill;
    //[SerializeField]
    //Text percentage;
    //[SerializeField]
    //bool ContainPercentage
    float filled;
    // Start is called before the first frame update
    void Start()
    {
        //filled = (float)1 / (timeFill * 3600);        
    }

    // Update is called once per frame
    void Update()
    {
        fill.fillAmount = SystemInfo.batteryLevel;
        //if  (SystemInfo.batteryStatus == BatteryStatus.Discharging)
        //{
        //    //Debug.Log(filled);
        //    fill.fillAmount -= filled;
        //    fill.color = new Color(1, 1, 1, 1);
        //    //percentage.text = ((int)(fill.fillAmount * 100)).ToString()+"%";
        //    if (fill.fillAmount < 0.15f)
        //    {
        //        fill.color = new Color(1, 0.33f, 0, 1);
        //    }
        //}
        //else
        //{
        //    fill.fillAmount += .01f;
        //}
    }
}
