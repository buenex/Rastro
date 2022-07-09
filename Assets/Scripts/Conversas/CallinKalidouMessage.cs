using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallinKalidouMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Lucas","CARAAAA !!O COLINS DAVIS FOI ANUNCIADO NO TIME DO FROSTE FUTEBOL CLUBE !!                                                                        ", true));
        Message.Add(new Message("CallinKalidou", "NÃO BRINCA !!! ESTÁ FALANDO SÉRIO?                                           ", false));
        Message.Add(new Message("Lucas","Sério !!acabou de acontecer !!                                               ", true));
        Message.Add(new Message("CallinKalidou", "Fico tão feliz com essa notícia,nosso time virá com tudo esse ano !!                                                                               ", false));
        Message.Add(new Message("Lucas" ,"Com Certeza, e temporada já começa amanhã dá pra acreditar ?                                                                                          ", true));
        Message.Add(new Message("CallinKalidou", "Fortes emoções !", false));
        Message.Add(new Message("CallinKalidou", "Vai ver o jogo ?", false));
        Message.Add(new Message("Lucas","Não perco por nada !!", true));

    }
}