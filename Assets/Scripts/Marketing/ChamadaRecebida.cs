using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamadaRecebida : MonoBehaviour
{
    public float time, delay;
    [SerializeField]
    GameObject telefone;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        delay = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time + delay )
        {
            telefone.SetActive(true);
            telefone.GetComponent<AnimationApp>().setOpen(true);
            telefone.transform.GetChild(5).gameObject.SetActive(true);
            GetComponent<ChamadaRecebida>().enabled = false;
        }//else if (Time.time > time + delay - 0.5f)
        //{
        //    telefone.SetActive(true);
        //    telefone.GetComponent<AnimationApp>().setOpen(true);
        //}
    }
}
