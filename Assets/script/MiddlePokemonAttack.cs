using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePokemonAttack : APokemonAttack
{
    public MiddlePokemonAttack()
    {
        name = "Middle";
        damage = 8;
    }

    public override void GetAttackInfo()
    {
        Debug.Log("MiddlePokemonAttack : " + Name + " fait " + Damage + " de dégàts.");
    }
}
