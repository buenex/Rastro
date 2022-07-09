using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndScene : MonoBehaviour
{
    [SerializeField]
    Image img;
    public static float tim;
    public static bool fim;
    [SerializeField]
    bool finish;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (fim && Time.time>=tim)
        {
            img.color += new Color(0, 0, 0, .02f);
            if (img.color.a >= 1)
            {
                SceneManager.LoadScene("Creditos");
            }
        }
    }
}
