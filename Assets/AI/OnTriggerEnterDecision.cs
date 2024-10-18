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
        if (TryGetComponent<ReturnToOriginAction>(out ReturnToOriginAction returnOriginComponent))
        {
            returnOriginComponent.originPos = transform.position;
        }
        if (TryGetComponent<DistanceDecision>(out DistanceDecision distanceDecisionComponent))
        {
            distanceDecisionComponent.originPos = transform.position;
        }

    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        PlayerDetected = false;
    }

}
