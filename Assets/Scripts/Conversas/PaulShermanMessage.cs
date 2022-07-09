using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulShermanMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Paul Sherman", "Bom dia Lucas. Gostaria de te agradecer pela doação dos brinquedos para o nosso projeto. As crianças adoraram, eu nem sei como lhe retribuir..                                                                                            ", false));

        Message.Add(new Message("Lucas","Disponha Paul.Não se preocupe, foi um prazer poder ajudar.                                                                                    ", true));
    }
}