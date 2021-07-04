using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Abilities/AbilityCore", order = 1)]
public class AbilityCore : ScriptableObject
{
    public float cooldown;
    public float manaCost;
    float onCD = 0f;

    IEnumerator WaitForCooldown()
    {
        if (onCD <= 0f)
        {
            onCD = 0;
        }
        if (onCD > 0)
        {
            onCD -= Time.deltaTime;
        }
        else
        {
            yield return null;
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
        }
    }
}
