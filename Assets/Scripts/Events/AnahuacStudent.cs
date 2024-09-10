using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacStudent : MonoBehaviour
{
    private void Start()
    {
        EventManager.m_Instance.AddListener<WinRaffle_Event>(WinRaffle);
    }
    private void WinRaffle(WinRaffle_Event _event)
    {
        Debug.Log("GANE UNA RIFA!");
    }
}
