using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BethyLodiMessage : MonoBehaviour, IMessage
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
        Message.Add(new Message("Bethy Lodi", "Olá Lucas como vai ? Meu nome é Bethy Lodi sou fundadora desenvolvedora do Forúm Bit Chan.                                                                                                 ", false));
        Message.Add(new Message("Lucas", "Olá, como posso ajuda-lá ? ", true));
        Message.Add(new Message("Bethy Lodi", "Alguns amigos me recomendaram falar com você, estou com problemas em estabelecer a segurança do meu site, será que pode me ajudar ?.                                                                                                      ", false));
        Message.Add(new Message("Lucas", "Claro, adoraria ajudar, me conte mais sobre o que está acontecendo.                                                                           ", true));
        Message.Add(new Message("Bethy Lodi", "Bom, recentemente levamos 2 ataques DDoS e alguns dados importantes foram roubados de nosso servidor.                                                                                         ", false));
        Message.Add(new Message("Bethy Lodi", "Alguns usuários também relataram a invasão de suas contas, isso é um enorme problema para um fórum que com uma proposta de manter o anonimato.                                                                          ", false));
        Message.Add(new Message("Lucas", "E já conseguiu rastrear o invasor ?                                                                        ", true));
        Message.Add(new Message("Bethy Lodi", "Acho melhor usarmos o termo “ Os “ invasores. Rastreamos ataques vindo das cidades A, B, C, E, F e H.                                                                                                                    ", false));
        Message.Add(new Message("Lucas", "Consegue me enviar os protocolos ?                                                                                                      ", true));
        Message.Add(new Message("Bethy Lodi", "Vou enviar um link com todos os arquivos.                                                                                                           ", false));
        Message.Add(new Message("Bethy Lodi", "sbt.litby.com//server ", false)); //Se possiver deixar em azul como se fosse um link
        Message.Add(new Message("Lucas", "Vou analisar ", true));
        Message.Add(new Message("Bethy Lodi", "Ok", false));
        Message.Add(new Message("Lucas", "Bem, acabei minha análise", true));
        Message.Add(new Message("Bethy Lodi", "E o que concluiu ?", false));
        Message.Add(new Message("Lucas", "Não diga nem mais uma palavra, a partir de agora nos comunicamos apenas pessoalmente, ok ?                                                                                            ", true));
        Message.Add(new Message("Bethy Lodi", "Entendi.. mas… como ? porque ? ", false));
        Message.Add(new Message("Lucas", "Me encontre na rua Adolfo Fera, Fr, Cidade Z, 1568 em uma hora.                                                                                          ", true));
        Message.Add(new Message("Bethy Lodi", "Estarei lá ", false));

    }
}