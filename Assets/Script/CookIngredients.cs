using NodeCanvas.Framework;
using UnityEngine;

public class CookIngredients : ActionTask
{
    private bool isCooked;

    protected override void OnExecute()
    {

    }

    private void MarkCooked()
    {
        isCooked = true;
        EndAction(true);
    }

    protected override void OnUpdate()
    {

        if (Random.Range(0f, 1f) < 0.1f)
            EndAction(false);
    }

    //protected override void OnStop() => CancelInvoke();
}