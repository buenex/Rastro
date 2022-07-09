using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calling : MonoBehaviour
{
    [SerializeField]
    //float speed, maxY, current, time, wait;
    float speed, time, wait;
    Vector3 current,maxY;
    bool up = true;
    // Start is called before the first frame update
    void Start()
    {
        //current = this.transform.position.y;
        current = new Vector3(.7f,.7f,1);
        speed = 0.02f;
        //maxY = this.transform.position.y + 0.3f;
        maxY = new Vector3(1.2f, 1.2f, 1);
        time = Time.time;
        //wait = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time + wait)
        {
            if (this.transform.localScale.x >= maxY.x)
            {
                up = false;
            }
            else if (this.transform.localScale.y <= current.y)
            {
                up = true;
            }
            //if (this.transform.position.y >= maxY)
            //{
            //    up = false;
            //}
            //else if (this.transform.position.y <= current)
            //{
            //    up = true;
            //}

            //if (up)
            //{
            //    this.transform.position += Vector3.up * speed;
            //}
            //else
            //{
            //    this.transform.position -= Vector3.up * speed;
            //}
            if (up)
            {
                this.transform.localScale += new Vector3(1,1,0) * speed;
            }
            else
            {
                this.transform.localScale -= new Vector3(1, 1, 0) * speed;
            }
        }
    }
}
