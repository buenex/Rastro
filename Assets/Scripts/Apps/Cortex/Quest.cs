using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    [SerializeField]
    GameObject[] missions;
    [SerializeField]
    GameObject[] check;
    public static bool[] conclude;

    // Start is called before the first frame update
    void Awake()
    {
        conclude = new bool[6];
        missions[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < mission.missions.Count; i++)
        {
            if (mission.missions[i])
            {
                missions[i].SetActive(true);
                if (mission.conclude[i])
                {
                    check[i].SetActive(true);
                }
            }
        }
    }
}
