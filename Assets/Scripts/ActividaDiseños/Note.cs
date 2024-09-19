using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private IEnumerator CR_Countdown()
    {
        //Counts 1 second
        //Destroys the the game object
        while (true)
        {
            yield return new WaitForSeconds(1); //Primero retorna esto, activando WaitForSeconds antes de lo siguiente
            ///Destroy(this.gameObject);
            PoolManager.Instance.ReturnObjectToPool(this.gameObject);
        }
    }

    void Start()
    {
        StartCoroutine(CR_Countdown());
    }
    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }


}
