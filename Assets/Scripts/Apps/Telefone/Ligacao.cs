using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ligacao : MonoBehaviour
{
    [SerializeField]
    GameObject telaLigacao;
    AudioSource source;
    Image[] fotoTarget;    
    Image foto;
    [SerializeField]
    AudioClip clip;
    Text numeroTarget;    
    Text[] numero;

    // Start is called before the first frame update
    void Start()
    {
        fotoTarget = telaLigacao.GetComponentsInChildren<Image>();
        numeroTarget = telaLigacao.GetComponentInChildren<Text>();
        source = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PreparaTela(GameObject classe)
    {
        telaLigacao.transform.GetChild(2).transform.GetChild(0).GetComponent<Image>().sprite = classe.transform.GetChild(0).transform.GetChild(0).GetComponentInChildren<Image>().sprite;
        telaLigacao.GetComponentsInChildren<Text>()[0].text = classe.transform.GetComponentInChildren<Text>().text;

        telaLigacao.SetActive(true);
        source.PlayOneShot(clip);
    }

    public void PreparaTelaDigitar(GameObject classe)
    {
        telaLigacao.transform.GetChild(2).transform.GetChild(0).GetComponent<Image>().sprite = classe.transform.transform.GetChild(0).GetComponentInChildren<Image>().sprite;
        telaLigacao.GetComponentsInChildren<Text>()[0].text = classe.transform.GetComponentsInChildren<Text>()[12].text;

        telaLigacao.SetActive(true);
        source.PlayOneShot(clip);
    }

    public void desliga(GameObject ligacao)
    {
        ligacao.SetActive(false);
    }
}
