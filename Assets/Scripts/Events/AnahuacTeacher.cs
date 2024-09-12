using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacTeacher : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        EventManager.m_Instance.AddListener<WinRaffle_Event>(WinRaffle);
    }
    public void WinRaffle(WinRaffle_Event _event)
    {
        Debug.Log("GANE UNA MAESTRO RIFA!");
    }
}
