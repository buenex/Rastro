using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionConfig : MonoBehaviour
{
    public enum resolution { x360, x480, x600, x720 };

    public void setResolution(int resol)
    {
        switch (resol)
        {
            case (int)resolution.x360:
                Screen.SetResolution(360, 720, false);
                break;
            case (int)resolution.x480:
                Screen.SetResolution(480, 854, false);
                break;
            case (int)resolution.x600:
                Screen.SetResolution(600, 1066, false);
                break;
            case (int)resolution.x720:
                Screen.SetResolution(720, 1280, false);
                break;
        }
    }

    // Update is called once per frame
    public void changed(int index)
    {       
        setResolution(index);
    }
}
