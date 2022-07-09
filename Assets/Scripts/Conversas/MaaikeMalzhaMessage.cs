using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaaikeMalzhaMessage : MonoBehaviour, IMessage
{
    public List<Message> Message { get; set; }
    [SerializeField]
    BuildMessage script;

    public void addMessage(Message message)
    {
        throw new System.NotImplementedException();
    }

    void Awake()
    {
        Message = new List<Message>();
        Message.Add(new Message("Maaike Malzha", "Eai cara ! tudo em cima ?", false));
       
        Message.Add(new Message("Lucas", "Hey Maaike, vou bem e vc ?", true));
        Message.Add(new Message("Maaike Malzha", "Tudo tranquilo por aqui.", false));
        Message.Add(new Message("Maaike Malzha", "Estou saindo para dar aquela caminhada matinal, me acompanha ?", false));
        Message.Add(new Message("Lucas", "Combinado, te encontro em 15 minutos.", true));
        Message.Add(new Message("Maaike Malzha", "A caminho.", false));
    }
}
