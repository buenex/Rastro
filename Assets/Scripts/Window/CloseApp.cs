using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApp : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<AnimationApp>().setOpen(false);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().closeApplication();
        }    
    }

    //private void OnMouseDown()
    //{
    //    transform.parent.GetComponent<AnimationApp>().setOpen(false);
    //}
}
