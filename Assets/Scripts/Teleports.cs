using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform Player;
    public Transform startLoc;
    public Transform Lvl1;
    public Transform Lvl2;
    public Transform Lvl3;
    public Transform Lvl4;

    public void TeleStart()
    {
        Player.transform.position = startLoc.position;
    }

    public void TeleLvl1()
    {
        Player.transform.position = Lvl1.position;
    }

    public void TeleLvl2()
    {
        Player.transform.position = Lvl2.position;
    }

    public void TeleLvl3()
    {
        Player.transform.position = Lvl3.position;
    }

    public void TeleLvl4()
    {
        Player.transform.position = Lvl4.position;
    }
}
