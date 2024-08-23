using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum MiLista
{
    Yo,
    Tu,
    El,
    Ella,
    Ellos
}
public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject BulletClone = Instantiate(BulletPrefab);
            BulletClone.transform.position = spawnPoint.position;
            BulletClone.transform.rotation = spawnPoint.rotation;
            BulletClone.GetComponent<Rigidbody>().AddForce(spawnPoint.transform.forward * 100.0f);
        }
        
    }
}
