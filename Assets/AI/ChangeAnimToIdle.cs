using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimToIdle : AIAction
{
    public override void PerformAction()
    {
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<Animator>().SetBool("IsFollowing", false);
    }
}
