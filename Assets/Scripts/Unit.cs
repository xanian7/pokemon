using Assets.Scripts.Pokemon;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    [SerializeField] PokemonModel structure;
    [SerializeField] int level;

    bool isPlayer;

    public GetPokemon pokemon { get; set; }

    public void Setup()
    {
        pokemon = new GetPokemon(structure, level);
        if (isPlayer)
        {
            GetComponent<Image>().sprite = pokemon.Model.Back;
        }
        else
        {
            GetComponent<Image>().sprite = pokemon.Model.Front;
        }
    }
}
