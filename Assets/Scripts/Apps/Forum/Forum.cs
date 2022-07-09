using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forum : MonoBehaviour
{
    public void guide(int tab)
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            transform.GetChild(tab).gameObject.SetActive(true);
            if (i != tab)
            {
                //Debug.Log("entrou");
                transform.GetChild(i).gameObject.SetActive(false);
            }

        }
    }// Start is called before the first frame update    
}
