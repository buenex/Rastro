using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TayRoseMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Tay Rose", "Oi sou Tay, tudo bem? Olha eu vi você fazendo a doação para as crianças da Fundação. Notei que fiquei atraída por você e sinto que tenho algo muito difícil para falar para você. Sinto que por mensagem é melhor para dizer.                                                                                                                  ", false));
        Message.Add(new Message("Lucas", "Olá, está tudo ótimo. Pode falar.", true));
        Message.Add(new Message("Tay Rose", "Err…. “Massachusetts”. Hahahahaha.", false));
        Message.Add(new Message("Lucas", "Hahaha engraçadinha.", true));
        Message.Add(new Message("Tay Rose", "Deixando a brincadeira de lado, achei muito nobre o que você pelas crianças                                                                                             ", false));
        Message.Add(new Message("Lucas", "Minha aquilo não foi nada.", true));
        Message.Add(new Message("Lucas", "Quero dizer minha atitude. As crianças merecem muito mais. Mas Obrigado.                                                                                                  ", true));
        Message.Add(new Message("Tay Rose", "De nada Lucas.", false));

    }
}