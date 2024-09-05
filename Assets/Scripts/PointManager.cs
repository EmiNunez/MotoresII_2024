using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    // Start is called before the first frame update
    //THIS IS A SINGLETON
    private static PointManager _instance; //Aparentemente hacerlo static es importante
                                            //Algo estatico significa que es inmutable desde afuera.

    public static PointManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<PointManager>(); //Intenta buscar uno
            } 
            return _instance; //Ahora tengo un singleton.
        }
    }

    private int score = 0;
    public int GetScore()
    {
        return score;
    }

    public void AddPoints( int points)
    {
        score += points;
    }

    public void RemovePoints(int points)
    {
        score -= points;
        if (score < 0) { score = 0; }   
    
    }
}
