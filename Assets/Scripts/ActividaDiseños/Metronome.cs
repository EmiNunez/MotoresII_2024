using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    [SerializeField] private GameObject notePrefab;
    [SerializeField] private Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.m_Instance.AddListener<PlayNote_Event>(PlayNote);
    }

    private void PlayNote(PlayNote_Event e)  //Invoca un evento
    {
        Note newNote = null;
        PoolManager.Instance.SpawnObject<Note>(out newNote, notePrefab, spawn.transform.position, spawn.transform.rotation, PoolManager.PoolType.GameObjects);
        Debug.Log("NEWNOTE");
    }

    
}
