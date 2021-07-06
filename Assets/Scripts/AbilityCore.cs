using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Abilities/AbilityCore", order = 1)]
public class AbilityCore : Ability
{
    public float cooldown;
    public float manaCost;
    float onCD = 0f;

    IEnumerator WaitForCooldown()
    {
        while (onCD > 0)
        {
            if (onCD <= 0f)
            {
                onCD = 0;
            }
            if (onCD > 0)
            {
                onCD -= Time.deltaTime;
                yield return null;
            }
        }
    }

    void Ability()
    {

    }

    public void Invoke()
    {
        if (!(onCD > 0))
        {
            Ability();
            onCD = cooldown;
            IEnumerator enumerator = WaitForCooldown();
            CoroutineHandler.instance.StartCoroutine(enumerator);
        }
    }
}
