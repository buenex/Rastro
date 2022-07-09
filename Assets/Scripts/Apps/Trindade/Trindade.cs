using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trindade : MonoBehaviour
{
    public void open(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void close(GameObject obj)
    {
        obj.SetActive(false);
    }
}
