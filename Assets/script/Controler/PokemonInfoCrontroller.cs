using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonInfoCrontroller : MonoBehaviour
{

    [SerializeField] private Image imgIcon;
    [SerializeField] private Text txtName;
    [SerializeField] private Text txtType;
    [SerializeField] private Button nextButton;
    [SerializeField] private Button SelectButton;

    [SerializeField] private DatabaseManager databaseManager;

    private int currentIndex = 0;
    
    private void Start()
    {

        nextButton.onClick.AddListener(nextButton_Click);
        SelectButton.onClick.AddListener(selectButton_Click);
        updatePokemon();
    }

    void nextButton_Click()
    {
        currentIndex = (currentIndex + 1) % databaseManager.datas.Count;
        updatePokemon();
    }

    void selectButton_Click()
    {
        APokemon.PokemonData pokemonData = databaseManager.datas[currentIndex];
        APokemon pokemon = new APokemon(pokemonData);
        pokemon.AddPokemonToAttackManager();
        SelectButton.enabled = false;
        nextButton.enabled = false;
    }

    private void updatePokemon()
    {
        APokemon.PokemonData pokeData = databaseManager.datas[currentIndex];

        imgIcon.sprite = pokeData.Icon;
        txtName.text = pokeData.Name;
        txtType.text = $"{pokeData.PokemonType.ToString()}";

    }

}