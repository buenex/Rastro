using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsConfig : MonoBehaviour
{
    public enum typ { geral,efeitos,musica};
    [SerializeField]
    Slider geral, efeitos, musica;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSound(int tp)
    {
        switch (tp)
        {
            case (int)typ.geral:
                efeitos.value = geral.value;
                musica.value = geral.value;
                GameController.mus = geral.value;
                GameController.ef = geral.value;
                break;
            case (int)typ.efeitos:
                GameController.ef = efeitos.value;
                break;
            case (int)typ.musica:
                GameController.mus = musica.value;
                break;
        }
    }
}
