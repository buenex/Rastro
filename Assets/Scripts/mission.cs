using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mission : MonoBehaviour
{
    [SerializeField]
    Image circle;
    [SerializeField]
    Sprite[] icons;
    [SerializeField]
    GameObject[] miss;
    [SerializeField]
    CortexMessage msg;
    public static int mission11Count;
    public enum missi {tutorial=80, not=0, mission1 =1, mission2 = 2, mission3 = 3, mission4 = 4, mission5 = 5,mission6=6,mission7=7,mission8=8,mission9=9,mission10=10 };
    public static List<bool> missions;
    public static bool[] conclude;
    private void Start()
    {
        conclude = new bool[15];
        missions = new List<bool>();
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
        missions.Add(false);
    }
    private void OnMouseUp()
    {
        if (circle.fillAmount >=.85f)
        {
            //Debug.Log("inspect");
        }
        else
        {
            //Debug.Log("not inspect");
        }
    }

    public void tutorial()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount == 1)
        {
            if (conclude[0])
            {
                GameController.del = Time.time+.5f;
                CortexMessage.mission2 = true;
                CortexMessage.delay = 2;
                CortexMessage.time = Time.time;
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Nova mensagem de cortex", true);
                Notification.up = false;
                Notification.active = true;
                missions[1] = true;
                GameController.err = false;
            }
        }
    }

    public void Miss1()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        Debug.Log(circle.fillAmount);
        if (circle.fillAmount >=.85f)
        {
            Debug.Log("mission[0] = "+ missions[0]+" mission[1]="+ missions[1]);
            if (missions[0] && !missions[1])
            {
                GameController.del = Time.time + .5f;
                CortexMessage.delay = 0;
                CortexMessage.time = Time.time;
                CortexMessage.mission1 = true;
               
                conclude[0] = true;
                GameController.err = false;
            }
        }        
    }

    public void Miss2()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[1] && !missions[2])
            {
                GameController.del = Time.time + .5f;
                Notification.notifics = new List<Notific>();
                GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Procure por mensagens sobre megan em mensagens com pessoas proximas.                                                                                              ", false, true, missi.mission3));
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.message), "Busque por mais informações nas mensagens", false);
                missions[2] = true;
                missions[3] = true;

                conclude[1] = true;
                GameController.err = false;
            }
        }
    }

    public void Miss3()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[2] && !conclude[2])
            {
                GameController.del = Time.time + .5f;
                ++mission45;
                Notification.notifics = new List<Notific>();
                if (mission45 == 1)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Pista 1 de 2 encontrado", false);
                }
                else if (mission45 == 2)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Pista 2 de 2 encontrado, volte na cortex", false);
                    GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Você está bem?            ", false));
                    missions[4] = true;
                }
                conclude[2] = true;
                GameController.err = false;
            }
        }
    }
    int mission45 = 0;
    public void Miss4()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[3]&& !conclude[3])
            {
                GameController.del = Time.time + .5f;
                ++mission45;
                Notification.notifics = new List<Notific>();
                if (mission45 == 1)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Pista 1 de 2 encontrado", false);
                }
                else if (mission45 == 2)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Pista 2 de 2 encontrado, volte na cortex", false);
                    GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Você está bem?            ", false));
                    missions[4] = true;
                }
                conclude[3] = true;
                GameController.err = false;
            }
        }        
    }    

    public void Miss5()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[4] && !missions[5])
            {
                GameController.del = Time.time + .5f;
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.tera), "Busque pistas no navegador", false);
                GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Parece ser um crime estranho, tem alguma pista de onde ocorreu? Busque mais pistas                                                                                                     ", false));
                missions[5] = true;
                conclude[4] = true;
                GameController.err = false;
            }
        }
        
    }

    public void Miss6()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[5] && !missions[6])
            {
                GameController.del = Time.time + .5f;
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Nova mensagem de cortex", false);
                GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Estou notando uma alta alteração na sua frequência cerebral                                                                                                      ", false));
                conclude[5] = true;
                CortexMessage.delay = 2;
                CortexMessage.time = Time.time;
                CortexMessage.mission6 = true;
                missions[6] = true;
                GameController.err = false;
            }
        }
        
    }

    public void Miss7()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[6] && !missions[7])
            {
                GameController.del = Time.time + .5f;
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Nova mensagem de cortex", false);
                GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Então aparentemente você estava tentando hackear o governo da cidade A ontem a noite                                                                                                     ", false));
                CortexMessage.delay = 2;
                CortexMessage.time = Time.time;
                CortexMessage.mission8 = true;
                conclude[6] = true;                
                missions[7] = true;
                GameController.err = false;
            }
        }

    }

    public void Miss8()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[7] && !missions[8])
            {
                GameController.del = Time.time + .5f;
                CortexMessage.delay = 2;
                CortexMessage.time = Time.time;
                CortexMessage.mission8 = true;
                conclude[7] = true;
                missions[8] = true;
                GameController.err = false;
            }
        }

    }

    public void Miss9()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[8] && !missions[9])
            {
                GameController.del = Time.time + .5f;
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Nova mensagem de cortex", false);
                GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Que tal buscar nesse fórum algo que possa te mostrar mais a fundo o que são essas tais luzes                                                                                                     ", false));
                CortexMessage.delay = 2;
                CortexMessage.time = Time.time;
                //CortexMessage.mission8 = true;
                conclude[8] = true;
                missions[9] = true;
                GameController.err = false;
            }
        }

    }

    public void Miss10()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[9] && !missions[10])
            {
                GameController.del = Time.time + .5f;
                GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Nova mensagem de cortex", false);
                GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "E aí, achou algo?                                                                                                     ", false));
                CortexMessage.delay = 2;
                CortexMessage.time = Time.time;
                conclude[9] = true;
                missions[10] = true;
                GameController.err = false;
            }
        }

    }

    public void Miss11()
    {
        circle = GameObject.FindGameObjectWithTag("circle").GetComponent<Image>();
        if (circle.fillAmount >=.85f)
        {
            if (missions[10] && !missions[11])
            {
                GameController.del = Time.time + .5f;
                mission11Count++;
                if (mission11Count == 1)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Pista 1/2 encontrada", false);
                    
                }
                else
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.cortex), "Pista 2/2 encontrada, volte a cortex", false);
                    GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "E então?                               ", false));
                    conclude[10] = true;
                    missions[11] = true;
                }

                GameController.err = false;
            }
        }

    }

    public void getMission(missi mission)
    {
        switch (mission)
        {
            case missi.not:
                break;
            case missi.mission1:
                Miss1();
                break;
            case missi.mission2:
                Miss2();
                break;
            case missi.mission3:
                Miss3();
                break;
            case missi.mission4:
                Miss4();
                break;
            case missi.mission5:
                Miss5();
                break;
            case missi.mission6:
                Miss6();
                break;
            case missi.mission7:
                Miss7();
                break;
            case missi.mission8:
                Miss8();
                break;
            case missi.mission9:
                Miss9();
                break;
            case missi.mission10:
                Miss10();
                break;
            default:
                break;
        }
    }

}
