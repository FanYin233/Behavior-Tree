using NodeCanvas.Framework;
using UnityEngine;

public class HasIngredients : ConditionTask
{
    public GameObject ingredient;

    protected override bool OnCheck()
    {
        return ingredient != null && ingredient.activeInHierarchy;
    }
}