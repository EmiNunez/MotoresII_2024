using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetAction : AIAction
{

    public float speed;
    public override void PerformAction()
    {
        if (_brain.Target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _brain.Target.position, step);
            transform.LookAt(_brain.Target.position);
        }
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<Animator>().SetBool("IsFollowing", true);
    }
}

