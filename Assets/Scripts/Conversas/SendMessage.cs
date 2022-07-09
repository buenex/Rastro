using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    public MonoBehaviour script;
    public BuildMessage build;
    IMessage messages;
    [SerializeField]
    InputField input;
    bool sendMsg;
    float tim;
    bool twice = false;
    [SerializeField]
    GameObject fim;

    GameObject countNotification;

    // Start is called before the first frame update
    void Awake()
    {
        messages = script.GetComponent<IMessage>();
        countNotification = GameObject.FindGameObjectWithTag("countNotification");
    }

    // Update is called once per frame
    public void sendMessage()
    {
        if (input.text.Trim() != "" && !mission.missions[0] && !mission.missions[1])
        {
            Notification.notifics.Remove(Notification.notifics[Notification.notifics.Count - 1]);
            messages.addMessage(new Message("Lucas", "Olá Cortex, apaguei por um dia inteiro, aconteceu algo na minha ausência?                                                                            ", true));
            CortexMessage.delay = 2;
            CortexMessage.time = Time.time;
            CortexMessage.mission0 = true;
            countNotification.SetActive(false);            
        }
        if(input.text.Trim() != "" && mission.missions[1] && mission.conclude[1] && mission.missions[3] && mission.conclude[3] && mission.missions[4] && !mission.conclude[4])
        {
            messages.addMessage(new Message("Lucas", "Megan Está morta?                     ", true));

            tim = Time.time + 2;
            sendMsg = true;
        }
        if (input.text.Trim() != "" && mission.missions[5] && mission.conclude[5] && mission.missions[6] && !mission.conclude[6] )
        {
            messages.addMessage(new Message("Lucas", "Era por volta de 1 da manhã,estava hackeando... Não me lembro quem                                                                                                   ", true));
            CortexMessage.delay = 2;
            CortexMessage.time = Time.time;
            CortexMessage.mission7 = true;
        }
        
        if (input.text.Trim() != "" && mission.missions[6] && mission.conclude[6] && mission.missions[7] && !mission.conclude[7] && !twice)
        {
            messages.addMessage(new Message("Lucas", "Sim, estou comecando a me lembrar                                                                                                   ", true));
            CortexMessage.delay = 2;
            CortexMessage.time = Time.time;
            CortexMessage.mission9 = true;
            twice = true;
        }
        else if (input.text.Trim() != "" && mission.missions[6] && mission.conclude[6] && mission.missions[7] && !mission.conclude[7]&&twice)
        {
            messages.addMessage(new Message("Lucas", "Eu lembro de ver algumas luzes na tela do meu computador, elas piscavam em uma frequência estranha, depois disso só me lembro de acordar, e estou aqui agora                                                            ", true));
            CortexMessage.delay = 2;
            CortexMessage.time = Time.time;
            CortexMessage.mission10 = true;
            mission.conclude[7] = true;
        }
        if (input.text.Trim() != "" && mission.missions[9] && mission.conclude[9] && mission.missions[10] && !mission.conclude[10] )
        {
            messages.addMessage(new Message("Lucas", "Oh não, minha mente está sendo controlada?                                                            ", true));
            sendMsg = true;
            tim = Time.time + 2;
        }
        if (input.text.Trim() != "" && mission.missions[10] && mission.conclude[10] && mission.missions[11] && !mission.conclude[11])
        {
            messages.addMessage(new Message("Lucas", "E...este...é o endereço de Megan...Eu estive lá ontem a noite, o que eu fiz?                                                            ", true));
            tim = Time.time + 4;
            //Método de final de jogo
            fim.SetActive(true);
            EndScene.tim = Time.time + 4;
            EndScene.fim = true;
        }
        input.text = "";
    }
    public void Update()
    {
        //Adicionar booleanos
        if (sendMsg&&Time.time>=tim && mission.missions[1] && mission.conclude[1] && mission.missions[3] && mission.conclude[3] && mission.missions[4] && !mission.conclude[4])
        {
            messages.addMessage(new Message("Lucas", "Estou desolado                     ", true));
            CortexMessage.delay = 2;
            CortexMessage.time = Time.time;
            CortexMessage.mission4 = true;
            sendMsg =false;
        }
        if(sendMsg && Time.time >= tim && mission.missions[9] && mission.conclude[9] && mission.missions[10] && !mission.conclude[10])
        {
            messages.addMessage(new Message("Lucas", "Preciso saber o que aconteceu comigo ontem a noite, onde eu estava?                                                    ", true));
            CortexMessage.delay = 2;
            CortexMessage.time = Time.time;
            CortexMessage.mission12 = true;
            sendMsg = false;
        }
    }

    public void sendCortexMessage(string message)
    {
        messages.addMessage(new Message("Cortex", message, false));

        build.build();
        input.text = "";
    }

    public string randomMessage()
    {
        switch ((int)Random.Range(0,5))
        {
            case 1:
                return "Desculpe, não te entendi :(";
            case 2:
                return "Aguarde para outras instruções";
            case 3:
                return "Sua missão pode ser encontrada na barra de notificação :)";
            case 4:
                return "Estou descansando não incomode >:(";
            case 5:
                return "...";
            default:
                return null;
        }
    }

}
