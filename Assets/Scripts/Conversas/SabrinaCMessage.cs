using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SabrinaCMessage : MonoBehaviour,IMessage
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
        Message.Add(new Message("Sabrina C", "Atualizei algumas informações do framework, nosso ataques serão mais fáceis agora.                                                                   ", false));
        Message.Add(new Message("Lucas", "Certo, já posso baixar ?", true));
        Message.Add(new Message("Sabrina C", "Um minuto, só mais algumas correções.                                                              ", false));
        Message.Add(new Message("Lucas", "Ok, aguardo.", true));
        Message.Add(new Message("Sabrina C", "lynint.by/ck26d631", false)); //Se possiver deixar em azul como se fosse um link
        Message.Add(new Message("Lucas", "Baixando...", true));
        Message.Add(new Message("Sabrina C", "Ótimo, o governo está se preparando cada vez mais para os ataques, os sistemas estão com algumas defesas                                                                                          ", false,true,mission.missi.mission7));
        Message.Add(new Message("Sabrina C", "Tome cuidado para não ser descoberto.                                                             ", false, true, mission.missi.mission7));
        Message.Add(new Message("Lucas", "Entendido.", true));

    }
}