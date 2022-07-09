using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarvinMcMinneyMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Marvin McKinney", "Quer fazer um #EnsaioFotográfico com direito e um #Teaser super bacana? Me chama aí... vamos conversar...                                                                                           ", false));

        Message.Add(new Message("Lucas","Quero não, muito obrigado.", true));
    }
}