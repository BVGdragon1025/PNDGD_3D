using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseState : MonoBehaviour, IFSMState
{
    //Public Variables
    public FSMStateType StateName { get { return FSMStateType.Chase; } }
    public float minChaseDistance = 2.0f;

    //Private Variables
    private Transform player = null;
    private NavMeshAgent thisAgent = null;

    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        thisAgent.GetComponent<NavMeshAgent>();
    }

    public void OnEnter()
    {
        thisAgent.isStopped = false;
    }

    public void OnExit()
    {
        thisAgent.isStopped = true;
    }

    public void DoAction()
    {
        thisAgent.SetDestination(player.position);
    }

    public FSMStateType ShouldTransitionToState()
    {
        float distanceToDest = Vector3.Distance(transform.position, player.position);
        if(distanceToDest <= minChaseDistance)
        {
            return FSMStateType.Attack;
        }
        return FSMStateType.Chase;
    }
}
