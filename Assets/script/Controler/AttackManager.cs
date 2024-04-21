using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    [SerializeField] private List<APokemon> attackers = new List<APokemon>();
    public List<APokemon> Attackers { get { return attackers; } }
    private int round = 0;
    private static AttackManager instance;
    public static AttackManager Instance { get => instance; }

    private void Awake()
    {
        InitInstance();
    }

    private void Start()
    {
        StartCoroutine(InitCombatLobby());
    }

    void InitInstance()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);

        instance = this;
    }

    IEnumerator InitCombatLobby()
    {
        while (attackers.Count < 2)
        {
            Debug.Log("Only " + attackers.Count + " Attackes");
            yield return new WaitForSeconds(0.5f);
        }
        StartCoroutine(PlayRounds());
    }



    public void Attack(APokemon attacker, APokemon opponent)
    {
        if (!attacker.IsPokemonAlive())
        {
            Debug.Log("This pokemon " + attacker.Data.Name + " is dead he can't attack");
        }
        if (attacker.IsPokemonAlive() && opponent.IsPokemonAlive())
        {
            attacker.AttackOpponent(opponent);
        }
    }

    IEnumerator PlayRounds()
    {
        APokemon pokemon1 = attackers[0];
        APokemon pokemon2 = attackers[1];
        while (pokemon1.IsPokemonAlive() && pokemon2.IsPokemonAlive())
        {
            round++;
            if (round % 2 == 1)
            {
                Attack(pokemon1, pokemon2);
            } else
            {
                Attack(pokemon2, pokemon1);
            }
            
            yield return new WaitForSeconds(1f);
        }
        if (pokemon1.IsPokemonAlive()) {
            Debug.Log("Le pokemon " + pokemon1.Data.Name + " à battu le pokemon " + pokemon2.Data.Name);
        }
        else
        {
            Debug.Log("Le pokemon " + pokemon2.Data.Name + " à battu le pokemon " + pokemon1.Data.Name);
        }
    }

}
