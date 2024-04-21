using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPokemonAttack : APokemonAttack
{   
    public BodyPokemonAttack()
    {
        name = "Body";
        damage = 10;
    }

    public override void GetAttackInfo()
    {
        Debug.Log("BodyPokemonAttack : " + Name + " fait " + Damage + " de dégàts.");
    }
}
