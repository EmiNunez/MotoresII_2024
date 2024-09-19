using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    public GameObject notePrefab;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.m_Instance.AddListener<PlayNote_Event>(PlayNote);
    }

    private void PlayNote(PlayNote_Event e)  //Invoca un evento
    {
        Note newNote;
        PoolManager.Instance.SpawnObject<Note>(out newNote, notePrefab, this.transform);
    }

    private void Update()
    {
        this.gameObject.transform.position += new Vector3(0, 1, 0);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PlayNote(new PlayNote_Event());
        }
    }
}
