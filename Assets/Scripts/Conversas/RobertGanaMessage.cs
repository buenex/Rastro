using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobertGanaMessage : MonoBehaviour,IMessage
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
        Message.Add(new Message("Lucas", "E ai, cara?                                                                                     ", true));
        Message.Add(new Message("Robert", "Oi mano, to aqui estudando alguns códigos, como se ta?                                                                                             ", false));
        Message.Add(new Message("Lucas", "Tudo bem aqui                                                                                     ", true));
        Message.Add(new Message("Lucas", "To com algumas ideias sobre aquele plano que te contei, lembra ?                                                                                                               ", true));
        Message.Add(new Message("Robert", "Lembro sim, mas continuo achando perigoso, em!                                                                                                                          ", false));
        Message.Add(new Message("Robert", "As condições que vivemos não é das melhores, mas você sabe que hackear e expor a cidade A não é uma boa ideia                                                                                     ", false));
        Message.Add(new Message("Robert", "E apesar deles serem corruptos, eu até penso em aceitar a proposta deles de trabalhar lá, sabia ? dar uma condição melhor pra minha família                                                                  ", false));
        Message.Add(new Message("Lucas", "Ah mas você nem brinca né, Robert, você sabe tudo o que eles fizeram, você é nossa arma tecnológica secreta, depois de mim claro!                                                                                              ", true));
        Message.Add(new Message("Robert", "Nem se acha o último hacker do pacote, né! haha Mas calma, você sabe que falo só da boca pra fora                                                                                           ", false));
        Message.Add(new Message("Lucas", "Assim espero!                                                                                     ", true));
        Message.Add(new Message("Robert", "Mas em relação ao plano: ainda acho perigoso                                                                                     ", false));
        Message.Add(new Message("Lucas", "Eu sei, mas temos que tentar algo, se não a a situação nunca vai mudar, e cada vez mais vão tirar de nós, não só dinheiro, mas comida, dignidade, e até amigos e entes queridos                                                       ", true));
        Message.Add(new Message("Lucas", "Você sabe do que eles são capazes                                                                      ", true));
        Message.Add(new Message("Lucas", "E além disso, temos que apoiar a Megan e a revolução que ela está fazendo                                                                                         ", true));
        Message.Add(new Message("Robert", "Estava demorando pra falar dela né, mas não me diga que está com esse plano todo só por causa dela, né ?                                                                         ", false));
        Message.Add(new Message("Lucas", "Não, né! É por toda a população                                                                               ", true));
        Message.Add(new Message("Lucas", "Mas enfim, vou colocar o plano em ação hoje, me deseje sorte!                                                                  ", true));
        Message.Add(new Message("Robert", "Tudo bem então, muita boa sorte!!                                                                                           ", false));
        Message.Add(new Message("Robert", "Ei, deu tudo certo? Você não me deu mais notícias                                                                                      ", false));
        Message.Add(new Message("Lucas", "Cara… nem sei te dizer, aconteceu algo muito estranho, que nunca tinha acontecido antes                                                                                     ", true));
        Message.Add(new Message("Lucas", "Eu havia invadido as barreiras de proteção do governo, conforme o planejado, e então eu apaguei                                                                                     ", true));
        Message.Add(new Message("Lucas", "Literalmente apaguei! Não me lembro de mais nada, só de uma luz muito forte                                                                                     ", true));
        Message.Add(new Message("Robert", "Nossa! Eu nunca ouvi falar nisso antes, e olha que eu entendo tudo de tecnologia                                                                                     ", false));
        Message.Add(new Message("Robert", "Espero que você não tenha se metido em confusão                                                                                     ", false));
        Message.Add(new Message("Lucas", "É… eu também espero.                                                                                     ", true));
        Message.Add(new Message("Robert", "A megan…                                                                                     ", false,true,mission.missi.mission4));
        Message.Add(new Message("Robert", "Ela...foi encontrada morta                                                                                     ", false, true, mission.missi.mission4));
        Message.Add(new Message("Lucas", "Eu sei. Não sei descrever o que estou sentindo                                                                                     ", true, true, mission.missi.mission4));
        Message.Add(new Message("Robert", "Eu sinto muito por isso.                                                                                     ", false, true, mission.missi.mission4));
    }
}
