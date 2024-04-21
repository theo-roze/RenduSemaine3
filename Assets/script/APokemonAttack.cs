using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APokemonAttack
{
    [SerializeField] protected string name;
    public string Name
    { get { return name; } }
    [SerializeField] protected int damage;
    public int Damage
    { get { return damage; } }

    public virtual void GetAttackInfo()
    {
        Debug.Log(name + " fait " + damage + " de dégàts.");
    }
}
