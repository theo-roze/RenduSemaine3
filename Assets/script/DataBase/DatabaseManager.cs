using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    // public PokemonDataBase database;

    public List<APokemon.PokemonData> datas = new();

    public Sprite iconBulbizarre;
    public Sprite iconHerbizarre;
    public Sprite iconFlorizarre;

    //test
    public Sprite iconCarapuce;
    public Sprite iconCarabaffe;
    public Sprite iconTortank;
    public Sprite iconSalamèche;
    public Sprite iconReptincel;
    public Sprite iconDracaufeu;
    public Sprite iconRattata;
    //test

    public void CreateData()
    {
        List<APokemon.PokemonType> weaknessesListBulbizarre = new List<APokemon.PokemonType>();
        weaknessesListBulbizarre.Add(APokemon.PokemonType.Fire);
        weaknessesListBulbizarre.Add(APokemon.PokemonType.Ice);
        List<APokemon.PokemonType> resistancesListBulbizarre = new List<APokemon.PokemonType>();
        resistancesListBulbizarre.Add(APokemon.PokemonType.Water);
        resistancesListBulbizarre.Add(APokemon.PokemonType.Grass);
        List<APokemonAttack> attacksBulbizarre = new List<APokemonAttack>();
        attacksBulbizarre.Add(new BodyPokemonAttack());
        attacksBulbizarre.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataBulbizarre = new APokemon.PokemonData("Bulbizarre", iconBulbizarre, 30, 5, 80,
            APokemon.PokemonType.Grass, weaknessesListBulbizarre,
            resistancesListBulbizarre, attacksBulbizarre);
        datas.Add(newDataBulbizarre);

        List<APokemon.PokemonType> weaknessesListHerbizarre = new List<APokemon.PokemonType>();
        weaknessesListHerbizarre.Add(APokemon.PokemonType.Poison);
        weaknessesListHerbizarre.Add(APokemon.PokemonType.Ice);
        List<APokemon.PokemonType> resistancesListHerbizarre = new List<APokemon.PokemonType>();
        resistancesListHerbizarre.Add(APokemon.PokemonType.Steel);
        resistancesListHerbizarre.Add(APokemon.PokemonType.Grass);
        List<APokemonAttack> attacksHerbizarre = new List<APokemonAttack>();
        attacksHerbizarre.Add(new BodyPokemonAttack());
        attacksHerbizarre.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataHerbizarre = new APokemon.PokemonData("Herbizarre", iconHerbizarre, 15, 7, 50,
            APokemon.PokemonType.Grass, weaknessesListHerbizarre,
            resistancesListHerbizarre, attacksHerbizarre);
        datas.Add(newDataHerbizarre);

        List<APokemon.PokemonType> weaknessesListFlorizarre = new List<APokemon.PokemonType>();
        weaknessesListFlorizarre.Add(APokemon.PokemonType.Poison);
        weaknessesListFlorizarre.Add(APokemon.PokemonType.Ice);
        List<APokemon.PokemonType> resistancesListFlorizarre = new List<APokemon.PokemonType>();
        resistancesListFlorizarre.Add(APokemon.PokemonType.Bug);
        resistancesListFlorizarre.Add(APokemon.PokemonType.Grass);
        List<APokemonAttack> attacksFlorizarre = new List<APokemonAttack>();
        attacksFlorizarre.Add(new BodyPokemonAttack());
        attacksFlorizarre.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataFlorizarre = new APokemon.PokemonData("Florizarre", iconFlorizarre, 25, 6, 130,
            APokemon.PokemonType.Grass, weaknessesListFlorizarre,
            resistancesListFlorizarre, attacksFlorizarre);
        datas.Add(newDataFlorizarre);

        //test
        // Ajout de Carapuce
        List<APokemon.PokemonType> weaknessesListCarapuce = new List<APokemon.PokemonType>();
        weaknessesListCarapuce.Add(APokemon.PokemonType.Electric);
        List<APokemon.PokemonType> resistancesListCarapuce = new List<APokemon.PokemonType>();
        resistancesListCarapuce.Add(APokemon.PokemonType.Water);
        List<APokemonAttack> attacksCarapuce = new List<APokemonAttack>();
        attacksCarapuce.Add(new BodyPokemonAttack());
        APokemon.PokemonData newDataCarapuce = new APokemon.PokemonData("Carapuce", iconCarapuce, 20, 8, 60,
            APokemon.PokemonType.Water, weaknessesListCarapuce,
            resistancesListCarapuce, attacksCarapuce);
        datas.Add(newDataCarapuce);

        // Ajout de Carabaffe
        List<APokemon.PokemonType> weaknessesListCarabaffe = new List<APokemon.PokemonType>();
        weaknessesListCarabaffe.Add(APokemon.PokemonType.Electric);
        List<APokemon.PokemonType> resistancesListCarabaffe = new List<APokemon.PokemonType>();
        resistancesListCarabaffe.Add(APokemon.PokemonType.Water);
        List<APokemonAttack> attacksCarabaffe = new List<APokemonAttack>();
        attacksCarabaffe.Add(new BodyPokemonAttack());
        attacksCarabaffe.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataCarabaffe = new APokemon.PokemonData("Carabaffe", iconCarabaffe, 25, 10, 80,
            APokemon.PokemonType.Water, weaknessesListCarabaffe,
            resistancesListCarabaffe, attacksCarabaffe);
        datas.Add(newDataCarabaffe);

        // Ajout de Tortank
        List<APokemon.PokemonType> weaknessesListTortank = new List<APokemon.PokemonType>();
        weaknessesListTortank.Add(APokemon.PokemonType.Electric);
        List<APokemon.PokemonType> resistancesListTortank = new List<APokemon.PokemonType>();
        resistancesListTortank.Add(APokemon.PokemonType.Water);
        List<APokemonAttack> attacksTortank = new List<APokemonAttack>();
        attacksTortank.Add(new BodyPokemonAttack());
        attacksTortank.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataTortank = new APokemon.PokemonData("Tortank", iconTortank, 30, 12, 100,
            APokemon.PokemonType.Water, weaknessesListTortank,
            resistancesListTortank, attacksTortank);
        datas.Add(newDataTortank);

        // Ajout de Salamèche
        List<APokemon.PokemonType> weaknessesListSalamèche = new List<APokemon.PokemonType>();
        weaknessesListSalamèche.Add(APokemon.PokemonType.Water);
        weaknessesListSalamèche.Add(APokemon.PokemonType.Rock);
        List<APokemon.PokemonType> resistancesListSalamèche = new List<APokemon.PokemonType>();
        resistancesListSalamèche.Add(APokemon.PokemonType.Fire);
        List<APokemonAttack> attacksSalamèche = new List<APokemonAttack>();
        attacksSalamèche.Add(new BodyPokemonAttack());
        APokemon.PokemonData newDataSalamèche = new APokemon.PokemonData("Salamèche", iconSalamèche, 22, 6, 70,
            APokemon.PokemonType.Fire, weaknessesListSalamèche,
            resistancesListSalamèche, attacksSalamèche);
        datas.Add(newDataSalamèche);

        // Ajout de Reptincel
        List<APokemon.PokemonType> weaknessesListReptincel = new List<APokemon.PokemonType>();
        weaknessesListReptincel.Add(APokemon.PokemonType.Water);
        weaknessesListReptincel.Add(APokemon.PokemonType.Rock);
        List<APokemon.PokemonType> resistancesListReptincel = new List<APokemon.PokemonType>();
        resistancesListReptincel.Add(APokemon.PokemonType.Fire);
        List<APokemonAttack> attacksReptincel = new List<APokemonAttack>();
        attacksReptincel.Add(new BodyPokemonAttack());
        attacksReptincel.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataReptincel = new APokemon.PokemonData("Reptincel", iconReptincel, 28, 8, 90,
            APokemon.PokemonType.Fire, weaknessesListReptincel,
            resistancesListReptincel, attacksReptincel);
        datas.Add(newDataReptincel);

        // Ajout de Dracaufeu
        List<APokemon.PokemonType> weaknessesListDracaufeu = new List<APokemon.PokemonType>();
        weaknessesListDracaufeu.Add(APokemon.PokemonType.Water);
        weaknessesListDracaufeu.Add(APokemon.PokemonType.Electric);
        List<APokemon.PokemonType> resistancesListDracaufeu = new List<APokemon.PokemonType>();
        resistancesListDracaufeu.Add(APokemon.PokemonType.Fire);
        List<APokemonAttack> attacksDracaufeu = new List<APokemonAttack>();
        attacksDracaufeu.Add(new BodyPokemonAttack());
        attacksDracaufeu.Add(new HeadPokemonAttack());
        APokemon.PokemonData newDataDracaufeu = new APokemon.PokemonData("Dracaufeu", iconDracaufeu, 35, 10, 110,
            APokemon.PokemonType.Fire, weaknessesListDracaufeu,
            resistancesListDracaufeu, attacksDracaufeu);
        datas.Add(newDataDracaufeu);

        // Ajout de Rattata
        List<APokemon.PokemonType> weaknessesListRattata = new List<APokemon.PokemonType>();
        weaknessesListRattata.Add(APokemon.PokemonType.Fighting);
        weaknessesListRattata.Add(APokemon.PokemonType.Fairy);
        List<APokemon.PokemonType> resistancesListRattata = new List<APokemon.PokemonType>();
        resistancesListRattata.Add(APokemon.PokemonType.Dark);
        resistancesListRattata.Add(APokemon.PokemonType.Ghost);
        List<APokemonAttack> attacksRattata = new List<APokemonAttack>();
        attacksRattata.Add(new BodyPokemonAttack());
        APokemon.PokemonData newDataRattata = new APokemon.PokemonData("Rattata", iconRattata, 18, 5, 40,
            APokemon.PokemonType.Normal, weaknessesListRattata,
            resistancesListRattata, attacksRattata);
        datas.Add(newDataRattata);
        //test
    }
    private void Awake()
    {
        datas = new();
        CreateData();
    }
}
