using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    GameObject notificationCount;
    [SerializeField]
    Text notificationCountText,message;
    [SerializeField]
    Image icon;
    [SerializeField]
    GameObject negation;

    public void openObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void closeObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void setNotification(bool state)
    {
        Notification.up = state;
        Notification.active = true;
    }

    public void notificationConfirm(bool state)
    {
        Notification.up = state;
        Notification.active = true;
        
    }

    public void notificationCancel(bool state)
    {
        Notification.up = state;
        Notification.active = true;
        Notification.notifics.Remove(Notification.notifics[Notification.notifics.Count - 1]);
        notificationCountText.text = Notification.notifics.Count.ToString();
        if (Notification.notifics.Count <= 0)
        {
            notificationCount.SetActive(false);
        }
    }

    public void notificationCountButton()
    {
        Notification.up = false;
        Notification.active = true;
        icon.sprite = Notification.notifics[Notification.notifics.Count - 1].icon;
        message.text = Notification.notifics[Notification.notifics.Count - 1].message;
        if (Notification.notifics[Notification.notifics.Count - 1].useNegation) { }
            //negation.SetActive(true);
        else
            negation.SetActive(false);
    }
    
    public void closeApp(AnimationApp app)
    {
        app.setOpen(!app.open);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().closeApplication();
    }

    public void sceneLoad(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
