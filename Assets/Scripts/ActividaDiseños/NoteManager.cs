using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static NoteManager instance;

    public static NoteManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<NoteManager>();
            }
            return instance;
        }
    }

    private int notes = 0;

    public int getNotes()
    {
        return notes;
    }
    public void Add_Note() 
    {
        //EventManager.m_Instance.InvokeEvent<PlayNote_Event>(new PlayNote_Event());
        notes++;
    }

   
}
