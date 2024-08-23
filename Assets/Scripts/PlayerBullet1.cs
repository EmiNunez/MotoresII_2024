using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet1 : MonoBehaviour
{
    private IEnumerator CR_Countdown()
    {
        //Counts 1 second
        //Destroys the the game object
        while (true) {
            yield return new WaitForSeconds(1); //Primero retorna esto, activando WaitForSeconds antes de lo siguiente
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
        StartCoroutine(CR_Countdown());    
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
