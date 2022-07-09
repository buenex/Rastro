using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationApp : MonoBehaviour
{
    public static bool appOppened;
    Image img;
    Vector3 reference;
    [SerializeField]
    public bool open;
    [SerializeField]
    float SpeedAnimation;
    float t;

    private void Awake()
    {
        appOppened = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        reference = new Vector3(SpeedAnimation, SpeedAnimation, 0);
        t = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (open && !appOppened) { 
            if (img.transform.localScale.x < 1 || img.transform.localScale.y < 1)
            {
                img.transform.localScale += reference;
            }
            else
            {
                //Debug.Log("App aberto");
                appOppened = true;
            }
        }
        else if (!open && appOppened)
        {
            if (img.transform.localScale.x > 0.1f || img.transform.localScale.y > 0.1f)
            {
                img.transform.localScale -= reference;
            }
            else
            {                
                transform.parent.gameObject.SetActive(false);
                appOppened = false;
                //Debug.Log("App fechado");
                this.gameObject.SetActive(false);
            }
        }        
    }
    public void setOpen(bool open)
    {
        this.open = open;
    }
}
