using NodeCanvas.Framework;
using UnityEngine;

public class ProcessIngredients : ActionTask
{
    private bool isProcessed;
    public float TargetTime = 2;
    public float currentTime;
    public float Tiktok;

    protected override void OnExecute()
    {
        currentTime = 0;
        Tiktok = currentTime + Time.deltaTime;
    }

    private void MarkProcessed()
    {
        isProcessed = true;
        EndAction(true);
    }

    protected override void OnUpdate()
    {
        if (Random.Range(0f, 1f) < 0.2f)
            EndAction(false);
    }


    //protected override void OnStop() => CancelInvoke();
}