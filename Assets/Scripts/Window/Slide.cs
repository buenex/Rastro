using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide : MonoBehaviour
{
    int count = 1;
    int last;
    bool move;
    float x;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject viewer;
    [SerializeField]
    Vector2[] listPosition;
    bool right;
    [SerializeField]
    float distance;
    [SerializeField]
    Vector2 current;
            
    // Start is called before the first frame update
    void Start()
    {
        last = 1;
    }

    // Update is called once per frame
    void Update()
    {
        current = viewer.transform.position;
        if (move)
        {
            if (last < count)
            {
                viewer.transform.position -= new Vector3(speed, 0);
                right = true;
            }
            else if (last > count)
            {
                viewer.transform.position += new Vector3(speed, 0);
                right = false;
            }
            else if (last == count && move)
            {
                if(viewer.transform.position.x > listPosition[count].x)
                {
                    viewer.transform.position -= new Vector3(speed/3, 0);
                }
                else if (viewer.transform.position.x < listPosition[count].x)
                {
                    viewer.transform.position += new Vector3(speed/3, 0);
                }
            }

            if (viewer.transform.position.x - listPosition[count].x < 1 && right)
            {                
                move = false;
                last = count;
            }
            else if (viewer.transform.position.x - listPosition[count].x > 1 && !right)
            {
                move = false;
                last = count;
            }
        }
        //Debug.Log(viewer.transform.position.x - listPosition[count].x );
        //Debug.Log(viewer.transform.position);
        //if(Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    x = Input.GetTouch(0).position.x;
        //}
        //if(Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    if (Input.GetTouch(0).position.x > x)
        //    {
        //        if (count < 2)
        //            count++;
        //    }else if(Input.GetTouch(0).position.x < x)
        //    {
        //        if (count > 0)
        //            count--;
        //    }            
        //}

        if (Input.GetMouseButtonDown(0))
        {
            x = Input.mousePosition.x;
            move = false;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.mousePosition.x > x)
            {              
                if (count > 0 && Input.mousePosition.x - x > distance)
                {
                    count--;
                    
                }
                move = true;
                //Debug.Log("IF-Count: "+count+"- Last:"+last);
            }
            else if (Input.mousePosition.x < x)
            {
                if (count < 2 && (Input.mousePosition.x - x) * -1 > distance)
                {
                    count++;
                    
                }
                move = true;
                //Debug.Log("ELSE-Count: " + count + "- Last:" + last);
            }
        }        
    }
}
