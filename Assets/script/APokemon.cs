using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static APokemon;

public class APokemon
{
    public enum PokemonType
    {
        Normal, Fire, Water, Electric, Grass, Ice, Fighting, Poison, Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
    }

    public struct PokemonData
    {
        [SerializeField] private string name;
        public string Name
        { get { return name; } }
        [SerializeField] private Sprite icon;
        public Sprite Icon
        { get { return icon; } }
        [SerializeField] private int startingHealth;
        public int StartingHealth
        { get { return startingHealth; }
            set { startingHealth = value; }
        }
        //[SerializeField] private int attack;
        //public int Attack
        //{ get { return attack; } }
        [SerializeField] private int defense;
        public int Defense
        { get { return defense; } }
        [SerializeField] private float weight;
        public float Weight
        { get { return weight; } }
        [SerializeField] private int stats;
        public int Stats
        { get { return stats; }
            set { stats = value; }
        }
        [SerializeField] private int currentHealth;
        public int CurrentHealth
        {
            get { return currentHealth; }
            set { currentHealth = value; }
        }
        [SerializeField] private PokemonType pokemonType;
        public PokemonType PokemonType
        { get { return pokemonType; } }
        [SerializeField] private List<PokemonType> weaknessesList;
        public List<PokemonType> WeaknessesList
        { get { return weaknessesList; } }
        [SerializeField] private List<PokemonType> resistancesList;
        public List<PokemonType> ResistancesList
        { get { return resistancesList; } }
        [SerializeField] private List<APokemonAttack> attacks;
        public List<APokemonAttack> Attacks
        { get { return attacks; } }

        public PokemonData(string name, Sprite icon, int startingHealth, int defense, float weight,
            PokemonType pokemonType, List<PokemonType> weaknessesList,
            List<PokemonType> resistancesList, List<APokemonAttack> attacks)
        {
            this.name = name;
            this.icon = icon;
            this.startingHealth = startingHealth;
            //this.attack = attack;
            this.defense = defense;
            this.weight = weight;
            this.stats = 0;
            this.currentHealth = 0;
            this.pokemonType = pokemonType;
            this.weaknessesList = weaknessesList;
            this.resistancesList = resistancesList;
            this.attacks = attacks;
        }
    }
    
    private PokemonData pokemonData;
    public PokemonData Data { get { return pokemonData; } }

    public APokemon(PokemonData pokemonData)
    {
        InitCurrentLife(ref pokemonData);
        InitStatsPoints(ref pokemonData);
        InitPokemonAttacks(ref pokemonData);
        this.pokemonData = pokemonData;
    }
    private void InitCurrentLife(ref PokemonData pokemonData)
    {
        pokemonData.CurrentHealth = pokemonData.StartingHealth;
    }

    private void InitStatsPoints(ref PokemonData pokemonData)
    {
        int attackValue = 0;
        foreach (APokemonAttack attack in pokemonData.Attacks)
        {
           attackValue += attack.Damage;
        }
        pokemonData.Stats = pokemonData.StartingHealth + attackValue + pokemonData.Defense;
    }

    private void InitPokemonAttacks(ref PokemonData pokemonData)
    {
        foreach (APokemonAttack attack in pokemonData.Attacks)
        {
            attack.GetAttackInfo();
        }
    }

    public void AddPokemonToAttackManager()
    {
        AttackManager.Instance.Attackers.Add(this);
    }

    public void DisplayPokemonData(ref PokemonData pokemonData)
    {
        Debug.Log("DisplayPokemonData");
        Debug.Log("  name " + pokemonData.Name);
        Debug.Log("  startingHealth " + pokemonData.StartingHealth);
        Debug.Log("  defense " + pokemonData.Defense);
        Debug.Log("  weight " + pokemonData.Weight);
        Debug.Log("  stats " + pokemonData.Stats);
        Debug.Log("  currentHealth " + pokemonData.CurrentHealth);
        Debug.Log("  pokemonType " + pokemonData.PokemonType);

        Debug.Log("  weaknessesList ");
        foreach (PokemonType weakness in pokemonData.WeaknessesList)
        {
            Debug.Log("    weakness " + weakness);
        }

        Debug.Log("  resistancesList ");
        foreach (PokemonType resistance in pokemonData.ResistancesList)
        {
            Debug.Log("    resistance " + resistance);
        }

        Debug.Log("  attacks ");
        foreach (APokemonAttack attack in this.pokemonData.Attacks)
        {
            Debug.Log("  name " + attack.Name);
            Debug.Log("  damage " + attack.Damage);
        }

    }

    public void DisplayPokemonLife(ref PokemonData pokemonData)
    {
        Debug.Log("La vie actuelle est de " + pokemonData.CurrentHealth.ToString());
    }

    public void AttackOpponent(APokemon opponent)
    {
       int index = Random.Range(0, pokemonData.Attacks.Count);
        opponent.TakeDamage(this, pokemonData.Attacks[index]);
    }

    public void TakeDamage(APokemon pokemon, APokemonAttack pokemonAttack)
    {
        int damage = pokemonAttack.Damage;
        PokemonType enemyType = pokemon.pokemonData.PokemonType;
       
        if (damage <= 0)
        {
            return;
        }
        float damageMultiplier = 1.0f;

        foreach (PokemonType weakness in this.pokemonData.WeaknessesList)
        {
            if (weakness == enemyType)
            {
                damageMultiplier *= 2.0f;
                break;
            }
        }

        foreach (PokemonType resistance in this.pokemonData.ResistancesList)
        {
            if (resistance == enemyType)
            {
                damageMultiplier *= 0.5f;
                break;
            }
        }

        this.pokemonData.CurrentHealth -= (int) (damage * damageMultiplier);

        this.pokemonData.CurrentHealth = Mathf.Max(this.pokemonData.CurrentHealth, 0);

        Debug.Log("Pokemon " + pokemonData.Name + " is current health after attack: " + this.pokemonData.CurrentHealth);

    }

    public bool IsPokemonAlive()
    {
        if (this.pokemonData.CurrentHealth <= 0)
        {
            Debug.Log("Pokemon " + pokemonData.Name + " is fainted.");
            return false;
        }
        else
        {
            Debug.Log("Pokemon " + pokemonData.Name + " is still alive.");
            return true;
        }
    }
}
