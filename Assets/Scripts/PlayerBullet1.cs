using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet1 : MonoBehaviour
{
    private IEnumerator Countdown()
    {
        //Counts 1 second
        //Destroys the the game object
        while (true) {
            yield return new WaitForSeconds(1);
            Destroy(this.gameObject);
        }   
    }

    private void OnTriggerEnter(Collider other) /// Checks for collisions
    {
        //On collision
        //Destroys the game object
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());    
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
