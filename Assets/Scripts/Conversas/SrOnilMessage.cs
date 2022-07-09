using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrOnilMessage : MonoBehaviour, IMessage
{
    public List<Message> Message { get; set; }
    [SerializeField]
    BuildMessage script;

    public void addMessage(Message message)
    {
        Message.Add(message);
        script.build();
    }

    void Awake()
    {
        Message = new List<Message>();
        Message.Add(new Message("Sr. Onil", "Ei garoto seus sapatos já estão conectado, pode passar aqui na minha loja para pegá-los amanhã                                                                                       ", false));
        Message.Add(new Message("Lucas", "Entendido, estarei ai amanhã cedo                                                                     ", true));


    }
}