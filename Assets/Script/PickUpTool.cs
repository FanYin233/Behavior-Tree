using NodeCanvas.Framework;
using UnityEngine;

public class PickUpTool : ActionTask
{
    public GameObject tool;

    protected override void OnExecute()
    {
        if (tool == null)
        {
            Debug.Log("Error");
            EndAction(false);
            return;
        }
        tool.transform.SetParent(agent.transform);
        EndAction(true);
    }
}