using NodeCanvas.Framework;
using UnityEngine;

public class IsOnFire : ConditionTask
{
    public bool isFire;

    protected override bool OnCheck() => isFire;
}