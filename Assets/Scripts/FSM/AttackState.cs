using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : MonoBehaviour, IFSMState
{
    //Public Variables
    public FSMStateType StateName {get {return FSMStateType.Attack; } }
    public ParticleSystem weaponPS = null;

    //Private Variables
    private Transform thisPlayer = null;

    public void OnEnter()
    {
        weaponPS.Play();
    }

    public void OnExit()
    {
        weaponPS.Stop();
    }

    public void DoAction()
    {
        Vector3 dir = (thisPlayer.position - transform.position).normalized;
    }

    public FSMStateType ShouldTransitionToState()
    {
        return FSMStateType.Attack;
    }

}
