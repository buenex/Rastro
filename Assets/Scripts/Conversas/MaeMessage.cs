using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaeMessage : MonoBehaviour,IMessage
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
        Message.Add(new Message("Lucas", "Oi mãe, como você está?                                                                      ", true));
        Message.Add(new Message("Mãe", "Oi meu amor, tá tudo bem aqui, como estão as coisas ai? Ainda recebendo mensagem daquela gente da cidade A ?                                                                                ", false));
        Message.Add(new Message("Lucas", "Tá tudo ok, estou conseguindo me adaptar morando sozinho                                                                      ", true));
        Message.Add(new Message("Lucas", "E sim… Aqueles corruptos não desistem de fazer eu mudar pro lado deles.                                                                                   ", true));
        Message.Add(new Message("Mãe", "Ai Ai, isso me deixa muito preocupada, tenho medo de tentarem fazer algo com você                                                                                  ", false));
        Message.Add(new Message("Mãe", "Você sabe como eles são perigosos quando não conseguem o que querem                                                                                                 ", false));
        Message.Add(new Message("Lucas", "Eu sei mãe, mas fica sossegada                                                         ", true));
        Message.Add(new Message("Lucas", "Não tem nada que eles possam fazer que faça eu mudar de ideia!Eu sei me cuidar                                                                                            ", true));
        Message.Add(new Message("Lucas", "E olha só, tô até aprendendo a cozinhar sozinho                                     ", true));
        Message.Add(new Message("Mãe", "Tudo bem então! Qualquer coisa me liga, viu?                                                                       ", false));
        Message.Add(new Message("Mãe", "Estou orgulhosa de você, te amo <3                                                                           ", false));
        Message.Add(new Message("Lucas", "Pode deixar mãe, amo você                                                                             ", true));
        Message.Add(new Message("Mãe", "Filho… vi as notícias sobre a morte da Megan                                                                 ", false,true,mission.missi.mission3));
        Message.Add(new Message("Mãe", "Ela era uma menina incrível, nem dá pra acreditar que coisas terríveis assim possam acontecer com pessoas tão boas                                                    ", false, true, mission.missi.mission3));
        Message.Add(new Message("Mãe", "Eu sinto muito, sei o quanto ela era especial pra você!                                                                                         ", false, true, mission.missi.mission3));
        Message.Add(new Message("Lucas", "Estou arrasado mãe! Nem parece que é real,sinto que ela vai aparecer aqui a qualquer momento                                                                          ", true, true, mission.missi.mission3));
        Message.Add(new Message("Lucas", "Somente uma pessoa muito cruel poderia assassinado ela a sangue frio desse jeito.Infelizmente ela era uma pessoa pública, com muitos ideais que os mais poderosos não concordavam, todos são suspeitos                                                       ", true, true, mission.missi.mission3));
        Message.Add(new Message("Lucas", "Mas eu vou descobrir quem fez isso! Apesar de ainda estar muito confuso com tudo o que aconteceu                                                                                              ", true, true, mission.missi.mission3));
        Message.Add(new Message("Mãe", "Confuso? Como assim?                                                                       ", false, true, mission.missi.mission3));                        
        Message.Add(new Message("Lucas", "É… não me lembro muito bem sobre o dia de ontem, como se fosse um apagão                                                                                          ", true, true, mission.missi.mission3));
        Message.Add(new Message("Lucas", "Mas não se preocupa mãe, deve ser só um surto de nerd de tanto tempo na frente do computador                                                                                      ", true, true, mission.missi.mission3));
        Message.Add(new Message("Lucas", "Qualquer coisa te mando mensagem, muito obrigado por me dar apoio nesse momento, vou ficar bem....                                                                                        ", true));
        Message.Add(new Message("Mãe", "Tudo bem então, qualquer coisa me liga beijos                                                      ", false));
    }
}
