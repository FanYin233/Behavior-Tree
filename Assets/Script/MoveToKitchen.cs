using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

public class MoveToKitchen : ActionTask
{
    public Transform kitchenPosition;
    private NavMeshAgent agent;

    protected override void OnExecute()
    {
        agent = agent.GetComponent<NavMeshAgent>();
        agent.SetDestination(kitchenPosition.position);
    }

    protected override void OnUpdate()
    {
        if (agent.remainingDistance <= 0.1f)
            EndAction(true);
        else if (agent.pathStatus == NavMeshPathStatus.PathPartial)
            EndAction(false);
    }
}