using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JordaGrennMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Jorda Grenn", "Olá Lucas como vai ?", false));
        Message.Add(new Message("Lucas", "Vou muito bem, obrigado.Como posso ajudar ?                                                        ", true));
        Message.Add(new Message("Jorda Grenn", "Sou uma das fundadoras da construtora TDG. Trabalhamos principalmente na construção de hotéis de luxo e digamos que minha empresa deseja expandir até as cidades menores.                                                                                 ", false));
        Message.Add(new Message("Lucas", "Não entendo o porquê construir hotéis de luxo em regiões onde as pessoas não conseguem nem comprar o que comer direito. ", true));
        Message.Add(new Message("Jorda Grenn", "Não nos importamos com os residentes, temos interesse na geografia da região e pretendemos atrair as pessoas do alto escalão para eles. Cedo ou tarde os grandes irão invadir essa corja rica e nós queremos ser os primeiros.                                                                              ", false));
        Message.Add(new Message("Jorda Grenn", "Vamos direto ao ponto, tem uma defensora pública dos direitos humanos, digamos que está em nosso caminho e sua atuação na sociedade em pró desses imundos e meio que atrapalha os nossos negócios. Então o que você me diz de sujar o nome dela na mídia para fragiliza-la politicamente?.                                                                                       ", false));
        Message.Add(new Message("Lucas", "Sinto muito.Mas eu não aceito.       ", true));
       Message.Add(new Message("Jorda Grenn", "Pense no que você está escolhendo. Podemos torná-lo alguém muito rico                                                                            ", false));

    }
}
