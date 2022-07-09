using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppAnimationRect : MonoBehaviour
{
    
    RectTransform img;
    Vector3 reference;
    [SerializeField]
    bool open;
    [SerializeField]
    float SpeedAnimation;
    float t;

    
    // Start is called before the first frame update
    void Start()
    {        
        img = GetComponent<RectTransform>();
        reference = new Vector3(SpeedAnimation, SpeedAnimation, 0);
        t = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            if (img.localScale.x < 1 || img.transform.localScale.y < 1)
            {
                img.transform.localScale += reference;
                Debug.Log("Abrindo App");
            }            
        }
        else if(!open)
        {
            if (img.transform.localScale.x > 0.1f || img.transform.localScale.y > 0.1f)
            {
                img.transform.localScale -= reference;
                Debug.Log("Fechando App");
            }
            else
            {
                transform.parent.gameObject.SetActive(false);                
                this.gameObject.SetActive(false);
            }
        }
    }
    public void setOpen(bool open)
    {
        this.open = open;
    }
}
