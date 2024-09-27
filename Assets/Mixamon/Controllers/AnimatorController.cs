using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;

    private int isWalkingHash; //Este int existe para alivianar la carga de leer un string a leer un int, que es más ligero.
    private int isRunningHash;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("IsWalking"); //Convierte mi propiedad a hash. La funcion se encuentra en la clase
        isRunningHash = Animator.StringToHash("IsRunning"); //FIJATE QUE SE LLAMEN IGUAL
    }

    private void Update()
    {
        /*
         * if (Input.GetKey(KeyCode.W)) //Checa si la tecla W está presionada
        {
            animator.SetBool("IsWalking", true);
        }
        if (!Input.GetKey(KeyCode.W)) //Checa si la tecla W está presionada
        {
            animator.SetBool("IsWalking", false);
        }
        */

        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool Forward = Input.GetKey(KeyCode.W);
        bool Dash = Input.GetKey(KeyCode.LeftShift);

        if (Forward && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (!Forward && isWalking) {
            animator.SetBool(isWalkingHash, false);
        }

        if ((Forward && Dash) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        if ((!Forward|| !Dash) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
