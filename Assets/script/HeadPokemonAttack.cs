using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadPokemonAttack : APokemonAttack
{

    public HeadPokemonAttack()
    {
        name = "Head";
        damage = 15;
    }

    public override void GetAttackInfo()
    {
        Debug.Log("HeadPokemonAttack : " + Name + " fait " + Damage + " de dégàts.");
    }
}
