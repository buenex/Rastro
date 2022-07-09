using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    public Sprite icon;    
    public string message;
    public bool useNegation;

    [SerializeField]
    Image notificationIcon;
    [SerializeField]
    Text notificationMessage;
    [SerializeField]
    GameObject notificationNegation;
    [SerializeField]
    Sprite[] icons;
    Vector3 initialPosition;
    Vector3 finalPosition;
    RectTransform rect;
    public static bool active;
    [SerializeField]
    float speed;
    public static List<Notific> notifics;
    public static bool up;
    bool stretch;
    [SerializeField]
    GameObject countCortex;
    GameObject countNotification;
    public enum ico { urbano = 0, tera = 1, cortex = 2, music = 3, galeria = 4, call = 5, mail = 6, message = 7,banco=8,forum=9 };

    private void Awake()
    {        
        notifics = new List<Notific>();
    }

    // Start is called before the first frame update
    void Start()
    {        
        up = false;
        stretch = true;
        rect = GetComponent<RectTransform>();
        initialPosition = this.rect.position;
        finalPosition = this.rect.position;
        finalPosition.y = finalPosition.y-2.5f;
        countNotification = GameObject.FindGameObjectWithTag("countNotification");
        countNotification.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (active)
        {
            //if (!up)
            //{
            //    rect.localScale += Vector3.up * speed;
            //}
            //else if (up)
            //{
            //    rect.localScale += Vector3.down * speed;
            //}
            if (!up)
            {
                rect.position += Vector3.down * .1f;
                //Debug.Log(rect.position.y);
                //Debug.Log("entrou down count");
            }
            else if (up)
            {
                rect.position += Vector3.up* .1f;
                //Debug.Log(rect.position.y);
                //Debug.Log("entrou up count");
            }

            //if (rect.localScale.y < 0)
            //{
            //    rect.localScale = new Vector3(1, 0, 1);
            //    up = false;
            //    active = false;
            //}
            //else if (rect.localScale.y >= 1)
            //{
            //    rect.localScale = new Vector3(1, 1, 1);
            //    up = true;
            //    active = false;
            //}
            if (rect.position.y< 5)
            {
                rect.position = new Vector3(0,5,110);
                up = false;
                active = false;
                //Debug.Log("entrou down");
            }
            else if (rect.position.y > 8)
            {
                rect.position = new Vector3(0, 8, 110);
                up = true;
                active = false;
                //Debug.Log("entrou up");
            }

            

            //if (rect.position.y < finalPosition.y)
            //{
            //    up = true;
            //    active = false;
            //}else if (rect.position.y > initialPosition.y)
            //{
            //    up = false;
            //    active = false;
            //}
            //if (!up)
            //{
            //    rect.localPosition += Vector3.down* speed;
            //}
            //else if(up)
            //{
            //    rect.localPosition += Vector3.up * speed;
            //}
        }
            
    }

    public void addNotificacao(Sprite icon,string message,bool useNegation)
    {
        notifics.Add(new Notific(icon, message, useNegation));
        up = false;
        active = true;
        notificationIcon.sprite = icon;
        notificationMessage.text = message;
        if (useNegation) { }
        //notificationNegation.SetActive(true);
        else
            notificationNegation.SetActive(false);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<Sound>().playClip(Sound.sound.notification);
        countNotification.SetActive(true);
        countCortex.SetActive(true);
    }
    public Sprite getSprite(ico ico)
    {        
        return icons[(int)ico];
    }
}

public class Notific
{
    public Sprite icon { get; set; }
    public string message { get; set; }
    public bool useNegation { get; set; }

    public Notific(Sprite icon,string message,bool useNegation)
    {
        this.icon = icon;
        this.message = message;
        this.useNegation = useNegation;
    }
}

