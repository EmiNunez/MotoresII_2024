using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterDecision : AIDecision
{
    private bool PlayerDetected = false;
    public override bool Decide()
    {
        return PlayerDetected;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _brain.Target = other.transform;
            PlayerDetected = true;
        }
    }

    public override void OnExitState()
    {
        base.OnExitState();
        PlayerDetected = false;
    }

}
