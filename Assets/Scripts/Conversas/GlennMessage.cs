using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlennMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Glenn Stefan", "Ei cara, aqui é o Glenn, um dos administradores do fórum BitChan                                                                                                         ", false));
        Message.Add(new Message("Glenn Stefan", "Queria agradecer pela ajuda com a segurança de nosso site                                                                                                         ", false));
        Message.Add(new Message("Lucas", "Sem problemas cara, pode contar comigo                                                                                  ", true));
    }
}