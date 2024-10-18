using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitDecision : AIDecision
{
    private bool PlayerDetected = true;
    public override bool Decide()
    {
        return PlayerDetected;
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") { 
            PlayerDetected = false;
            }
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        PlayerDetected = true;
    }
}
