using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMessage
{
    List<Message> Message { get; set; }
    void addMessage(Message message);
}
