using System.Collections;
using System.Collections.Generic;
using TMPro; // Estoy usando el plugin Text Mesh Pro
using UnityEngine;
using UnityEngine.UI; //Muy Importante si trabajas con UI

public class PointsUI : GameMonoBehaviour
{
    //Les variables
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = PointManager.instance.GetScore().ToString(); //Aquí ocurre la magia
    }

    public void OnClick_AddPoints() {
        PointManager.instance.AddPoints(10);
    }
    public void OnClick_SubtractPoints() {
        PointManager.instance.RemovePoints(3);
    }

    public void OnClick_WinRaffleEvent()
    {
        EventManager.m_Instance.InvokeEvent<WinRaffle_Event>(new WinRaffle_Event());//New, porque es un evento nuevo e independiente.
    }

    public void OnClick_NoLlegoElProfeEvent()
    {
        object[] parameter = new object[2];
        parameter[0] = "Motores 2";
        parameter[1] = Color.red;
        EventManager.m_Instance.InvokeEvent<NoLLegoElProfeEvent>(new NoLLegoElProfeEvent());
    }
}
