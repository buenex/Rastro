using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMessage : MonoBehaviour
{
    public MonoBehaviour message;
    List<Message> messages;
    [SerializeField]
    GameObject meMessage, yourMessage,mission;
    [SerializeField]
    RectTransform contentMessage;
    RectTransform reference;
    mission.missi mis;
    public bool buil;
    public float cnt;
    private void Awake()
    {
        reference = GetComponent<RectTransform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        build();
    }

    void Update()
    {
        if (buil)
        {
            build();
            buil = false;
        }
    }

    public void build()
    {
        reset();
        messages = message.GetComponent<IMessage>().Message;
        float tottaly = maxHeight(messages);
        contentMessage.offsetMax = new Vector2(0, tottaly);
        GameObject obj;
        RectTransform rect;
        float max = 1;
        int total = countTotal(messages);

        for (int i = 0; i < messages.Count; i++)
        {
            if (messages[i].Me)
            {
                obj = Instantiate(meMessage, contentMessage);
                obj.SetActive(true);
            }
            else
            {
                obj = Instantiate(yourMessage, contentMessage);
                obj.SetActive(true);
            }
            rect = obj.GetComponent<RectTransform>();
            if (messages[i].Me)
            {
                rect.anchorMax = new Vector2(1, max);
                max -= readyHeight(messages[i].Content, total);
                rect.anchorMin = new Vector2(readyWidth(messages[i]), max);
            }
            else
            {
                rect.anchorMax = new Vector2(readyWidth(messages[i]), max);
                max -= readyHeight(messages[i].Content, total);                
                rect.anchorMin = new Vector2(0, max);
            }
            if (messages[i].Quest)
            {
                mis = messages[i].Mission;
                obj.AddComponent<Button>();                
                obj.GetComponent<Button>().onClick.AddListener(delegate () { mission.GetComponent<mission>().getMission(mis); });
               // Debug.Log(i);
            }
            //rect.anchorMax = new Vector2(readyWidth(message[ i],me[i]), 1-(i* .15f));
            //rect.anchorMin = new Vector2(0,rect.anchorMax.y - .15f);
            Text nam = obj.GetComponentsInChildren<Text>()[0];
            nam.text = messages[i].Name;
            Text messag = obj.GetComponentsInChildren<Text>()[1];
            messag.text = messages[i].Content;
            adjustText(nam, messag);
            
        }
        meMessage.SetActive(false);
        yourMessage.SetActive(false);
        //if (contentMessage.offsetMax.y > 1250)
        //{
        //    contentMessage.position = new Vector3(contentMessage.position.x, 3.6f, -10);
        //    //Debug.Log(contentMessage.position.y);
        //}
        //else
        //{
        //    contentMessage.position = new Vector3(contentMessage.position.x, 3.6f, -10);
        //    //Debug.Log(contentMessage.position.y);
        //}
    }

    private int countTotal(List<Message> message)
    {
        int result = 0;
        for (int i = 0; i < message.Count; i++)
        {
            result++;
            int res = (int)Mathf.Ceil(message[i].Content.Length / 45);
            if (res == 0)
                res = 1;
            result += res;
        }
        return result;
    }
    void adjustText(Text name, Text message)
    {
        int constant = (message.text.Length / 45);
        constant = constant == 0 || constant == 1 ? 2 : constant++;

        name.rectTransform.anchorMax = new Vector2(1, 1);
        name.rectTransform.anchorMin = new Vector2(0, 1 - ((float)1 / constant));//alter y
        message.rectTransform.anchorMax = new Vector2(1, 1 - ((float)1 / constant));//alter y
        message.rectTransform.anchorMin = new Vector2(0, 0);
    }

    float maxHeight(List<Message> message)
    {
        int result = 0;
        for (int i = 0; i < message.Count; i++)
        {
            result += 50;
            int res = (int)ceil((float)message[i].Content.Length / (float)45);
            if (res == 0)
                res = 1;
            result += res * 50;
        }
        
        return result;
    }

    float readyHeight(string message, int total)
    {
        float result = 1;//.10f;
        int dif = (int)ceil((float)message.Length / (float)45);
        if (dif > 0)
        {
            result += dif;
        }
        else
        {
            result += 1;
        }
        
        return (float)result / (float)total ;
    }

    float readyWidth(Message message)
    {
        if (message.Content.Length <= 11)
        {
            if (message.Me)
                return .70f;
            else
                return .30f;
        }
        else if (message.Content.Length > 11 && message.Content.Length <= 20)
        {
            if (message.Me)
                return .50f;
            else
                return .50f;
        }
        else if (message.Content.Length > 20 && message.Content.Length <= 40)
        {
            if (message.Me)
                return .30f;
            else
                return .70f;
        }
        else
        {
            if (message.Me)
                return .20f;
            else
                return .80f;
        }
    }

    public  void reset()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        contentMessage.offsetMax-= contentMessage.offsetMax;
        contentMessage.offsetMin -= contentMessage.offsetMin;
    }

    int ceil(float number)
    {
        int integer = (int)number;
        float rest = number - integer;
        if (rest != 0)
        {
            return integer;
        }
        else
        {
            return integer;
        }
    }
}