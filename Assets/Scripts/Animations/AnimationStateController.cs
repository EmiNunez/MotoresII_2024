using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private float velocity;
    private int velocityHash;

    public float acceleration = 0.1f;
    public float decceleration = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        velocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if (forwardPressed && velocity < 1)
        {
            velocity += Time.deltaTime * acceleration; // se adapta a los cambios del framerate
        }
        if (!forwardPressed && velocity > 0)
        {
            velocity -= Time.deltaTime * decceleration;

        }


        animator.SetFloat(velocityHash, velocity);
    }
}
