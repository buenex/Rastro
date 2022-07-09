using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainIntro : MonoBehaviour
{
    [SerializeField]
    Image img;

    private void FixedUpdate()
    {
        img.color -= new Color(0, 0, 0, .006f);

        if (img.color.a <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
