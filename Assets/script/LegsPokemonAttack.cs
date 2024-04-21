using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsPokemonAttack : APokemonAttack
{
    public LegsPokemonAttack()
    {
        name = "Legs";
        damage = 5;
    }

    public override void GetAttackInfo()
    {
        Debug.Log("LegsPokemonAttack : " + Name + " fait " + Damage + " de dégàts.");
    }
}
