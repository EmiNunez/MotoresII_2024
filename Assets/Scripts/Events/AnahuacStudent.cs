using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacStudent : GameMonoBehaviour
{
    private void Start()
    {
        AddEventListener<WinRaffle_Event>(WinRaffle);
    }
    public void WinRaffle(WinRaffle_Event _event)
    {
        Debug.Log("GANE UNA RIFA!");
    }
}
