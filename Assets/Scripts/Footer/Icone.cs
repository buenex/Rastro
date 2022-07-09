using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icone : MonoBehaviour
{
    [SerializeField]
    GameObject appOpen;
    [SerializeField]
    GameObject appPainel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log("Entrou Click");
        if (!AnimationApp.appOppened)
        {
            appOpen.gameObject.SetActive(true);
            appOpen.GetComponent<AnimationApp>().setOpen(true);
            appPainel.SetActive(true);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().openApplication();

        }
    }
}
