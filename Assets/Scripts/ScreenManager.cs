using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]//Esto hace que la clase de abajo compile en el editor.
public class GameScreen //Esto hay que etiquetarlo para que ejecute en el editor
{
    public string id;
    public GameObject screen;
}

public class ScreenManager : MonoBehaviour
{
    private static ScreenManager _instance;

    public static ScreenManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ScreenManager>();
            }
            return _instance;
        }

    }

    public List<GameScreen> Screens;
}
