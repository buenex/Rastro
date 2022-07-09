using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseImage : MonoBehaviour
{
   public void close(GameObject obj)
    {
        obj.SetActive(false);
    }
}
