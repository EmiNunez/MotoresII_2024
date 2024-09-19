using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnahuacStudent : MonoBehaviour //UN LISTENER

{

    public Image imagen;
    private void Start()
    {
        imagen = GetComponent<Image>();
        EventManager.m_Instance.AddListener<WinRaffle_Event>(WinRaffle);
    }
    private void WinRaffle(WinRaffle_Event _event)
    {
        Debug.Log("GANE UNA RIFA!");
    }
    public void MevoyACasa(NoLLegoElProfeEvent _event)
    {
        object[] parameters = _event.GetParameters();
        Debug.Log("Me voy a casa pq no llegó el profe de" + parameters[0]);
        imagen.color = (Color)parameters[1]; //CAST de OBJETO a COLOR. recordemos que parameters guarda objetos, y objetos no equivale a colores.

    }
}
