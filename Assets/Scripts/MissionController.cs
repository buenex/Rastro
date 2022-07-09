using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    public static List<bool> mission;
    public enum missions {mission1=0,mission2=1,mission3=2,mission4=3,mission5=4 };
    // Start is called before the first frame update
    void Awake()
    {
        mission = new List<bool>();
        mission.Add(false);
        mission.Add(false);
        mission.Add(false);
        mission.Add(false);
        mission.Add(false);

    }

    public static void setMission(missions miss)
    {
        mission[(int)miss] = true;
    }
}
