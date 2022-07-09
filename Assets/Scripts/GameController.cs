using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    CortexMessage cortex;
    [SerializeField]
    bool a = true;
    bool mouse;
    public static float del=0;
    [SerializeField]
    public Image circle;
    public static bool handle;
    Vector2 circleInitialPosition;
    float count;
    bool valid;
    bool counter = true;
    public static bool err = true;
    [SerializeField]
    AudioClip openApp, closeApp,error;
    [SerializeField]
    AudioSource source;
    public static float ef = 1, mus = 1;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        //GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex),"Entre no aplicativo 'Cortex' e escreva algo !", false);
        //GameObject.FindGameObjectWithTag("notification").SetActive(false);

    }    

    // Update is called once per frame
    void FixedUpdate()
    {
        mouse = Input.GetMouseButton(0);

        if (mouse)
        {
            valid = true;
            if (counter)
            {
                circleInitialPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));
                count = Time.time;
                counter = false;
            }
            else
            {            
                if (Time.time >= count + .6f && rangeCircle(circleInitialPosition))
                {
                    circle.color = new Color(1, 1, 1, 1);
                    circle.rectTransform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));
                    circle.fillAmount += .04f;
                }

                if (!rangeCircle(circleInitialPosition))
                {
                    counter = true;
                }
            }            
        }
        else
        {
            
            if (circle.fillAmount != 1)
            {                
                handle = false;
                circle.fillAmount = 0;
                circle.transform.position = new Vector3(-10, -10, -10);
                counter = true;
            }
            else
            {
                if (valid)
                {
                    del = Time.time + .5f;
                    valid = false;
                }
                handle = true;
                if (err)
                {
                    circle.color = new Color(1, 0, 0, 1);                    
                }
                else
                {
                    circle.color = new Color(1, 1, 1, 1);
                }
                if (Time.time >= del)
                {
                    circle.fillAmount = 0;
                    circle.transform.position = new Vector3(-10, -10, -10);
                    counter = true;
                    if (err)
                    {
                        source.PlayOneShot(error);
                    }
                    err = true;
                }               
                           
            }
        }
    }

    bool rangeCircle(Vector2 Posi)
    {
        Vector2 dif  = Posi - (Vector2)Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));
        if (dif.x < 0 && dif.y < 0)
        {
            dif = dif * -1;
        }
        else if (dif.x < 0 && dif.y > 0)
        {
            dif = dif * Vector2.left;
        }
        else if (dif.x > 0 && dif.y < 0)
        {
            dif = dif * Vector2.down;
        }

        if ((dif.x <= .2f && dif.x >= 0) && (dif.y <= .2f && dif.y >= 0) )
        {
            return true;
        }
        return false;
    }

    public void openApplication()
    {
        source.volume = GameController.ef;
        source.PlayOneShot(openApp,.5f);
    }
    public void closeApplication()
    {
        source.volume = GameController.ef;
        source.PlayOneShot(closeApp,.5f);
    }
}


