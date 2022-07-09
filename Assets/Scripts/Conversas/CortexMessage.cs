using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CortexMessage : MonoBehaviour,IMessage
{
    public List<Message> Message { get; set; }
    [SerializeField]
    BuildMessage script;
    public static bool mission0, mission1, mission2, mission4, mission6, mission7, mission8,mission9,mission10,mission11,mission12;
    public static float delay,time;
    int message;
    IMessage messages;
    Sound source;

    void Awake()
    {
        message = 0;
        Message = new List<Message>();
        Message.Add(new Message("Cortex", "Bem vindo de volta senhor Lucas, não pude deixar de notar sua ausência.                                                                                          ", false));
        messages = GameObject.FindGameObjectWithTag("cortex").GetComponent<IMessage>();
        source = GameObject.FindGameObjectWithTag("GameController").GetComponent<Sound>();
    }

    void Update()
    {
        if (mission0)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Sim, há novidades mas antes acho melhor testar seus reflexos, vamos ver se ainda sabe \"inspecionar\" clique e segure AQUI para \"inspecionar\" essa mensagem.                               ", false, true, mission.missi.mission1));
                    time = Time.time;
                    Notification.up = true;
                    Notification.active = true;
                    mission.missions[0] = true;
                    mission0 = false;
                }
            }
        }
        if (mission1)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Ótimo, que tal tentar o mesmo com seu saldo bancario?                                                     ", false));
                    time = Time.time;
                    message = 1;
                    delay = 2;
                }
                else if (message == 1)
                {
                    messages.addMessage(new Message("Cortex", "Vá até o aplicativo do banco trindade e inspecione seu saldo.                                                                                                                        ", false));
                    time = Time.time;
                    message = 2;

                }
                else if (message == 2)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.banco), "Vá ao aplicativo Banco trindade", true);
                    Notification.up = false;
                    Notification.active = true;
                    message = 0;
                    mission1 = false;
                }
            }
        }
        if (mission2)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Noto a ausência de mensagens da senhorita Megan,que tal olhar suas mensagens.                                                                ", false));
                    message = 1;
                    time = Time.time;
                }
                else if (message == 1)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.message), "Busque pistas nas mensagens", true);
                    Notification.up = false;
                    Notification.active = true;
                    mission.missions[0] = true;
                    message = 0;
                    mission2 = false;
                }
            }
        }
        if (mission4)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Calma, não vamos perder a cabeça                                                                ", false));
                    message = 1;
                    time = Time.time;
                }
                else if (message == 1)
                {
                    messages.addMessage(new Message("Cortex", "Vamos tentar manter a cabeça no lugar                                                                ", false));
                    message = 2;
                    time = Time.time;
                }
                else if (message == 2)
                {
                    messages.addMessage(new Message("Cortex", "Recomendo que vá ao navegador e busque por mais notícias                                                                                                                                          ", false));
                    message = 3;
                    time = Time.time;
                }
                else if (message == 3)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.tera), "Busque pistas no navegador", true);
                    Notification.up = false;
                    Notification.active = true;
                    message = 0;
                    mission4 = false;
                }
            }
        }
        if (mission6)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Que tal me contar mais sobre o seu apagão ontem a noite?                                                                                                         ", false));
                    message = 1;
                    time = Time.time;

                    message = 0;
                    mission6 = false;
                }
            }
        }

        if (mission7)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Achei uma pista que pode te ajudar a lembrar.                                                               ", false));
                    message = 1;
                    time = Time.time;

                    message = 1;
                }
                else if (message == 1)
                {
                    messages.addMessage(new Message("Cortex", "Procure nas mensagens por Sabrina C.                                                               ", false));
                    message = 2;
                    time = Time.time;

                }
                else if (message == 2)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.message), "Entre no aplicativo de mensagens", true);
                    message = 2;
                    time = Time.time;

                    message = 0;
                    mission7 = false;
                }
            }
        }
        if (mission8)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "É isso?          ", false));
                    time = Time.time;
                    message = 0;
                    mission8 = false;
                }
            }
        }
        if (mission9)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    GameObject.FindGameObjectWithTag("cortex").GetComponent<CortexMessage>().addMessage(new Message("Cortex", "Certo, me conte o que ocorreu depois disso                               ", false));
                    time = Time.time;
                    message = 0;
                    mission9 = false;

                }
            }
        }
        if (mission10)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Certo! Vamos pesquisar mais sobre essa luz misteriosa                                                                                     ", false));
                    time = Time.time;
                    message = 1;
                }else if (message == 1)
                {
                    messages.addMessage(new Message("Cortex", "Acesse o forum bitchan para descobrir mais                                                                                    ", false));
                    time = Time.time;
                    message = 2;
                }else if (message == 2)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.forum), "Entre no aplicativo do forum", true);
                    time = Time.time;
                    mission.missions[8] = true;
                    message = 0;
                    mission10 = false;
                }
            }
        }
        if (mission11)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "É isso?          ", false));
                    time = Time.time;
                    message = 0;
                    mission11 = false;
                }
            }
        }
        if (mission12)
        {
            if (Time.time >= time + delay)
            {
                if (message == 0)
                {
                    messages.addMessage(new Message("Cortex", "Espera... Acho que encontrei uma pista de onde poderia estar                                                              ", false));
                    time = Time.time;
                    message = 1;
                }
                if (message == 1)
                {
                    messages.addMessage(new Message("Cortex", "Procure nos seus emails por recibos do urbano                                                        ", false));
                    time = Time.time;
                    message = 2;

                }
                if (message == 2)
                {
                    GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().addNotificacao(GameObject.FindGameObjectWithTag("notification").GetComponent<Notification>().getSprite(Notification.ico.mail), "Entre no aplicativo de email", true);
                    time = Time.time;
                    message = 0;
                    mission12 = false;
                }
            }
        }
    }

    public void addMessage(Message message)
    {
        Message.Add(message);
        script.build();
        if(!message.Me)
        source.playClip(Sound.sound.message);
    }
}
