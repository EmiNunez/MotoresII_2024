using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToOriginAction : AIAction
{
    public Vector3 originPos;
    public float speed = 1.0f;

    public override void PerformAction()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, originPos, step);
        transform.LookAt(originPos);
    }

}
