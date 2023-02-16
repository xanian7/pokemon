using UnityEngine;
using Assets.Scripts.Models;

namespace Assets.Scripts.Pokemon
{
    public class GetPokemon
    {
        PokemonStructure _pokemon;
        int _level;
        public GetPokemon(PokemonStructure pokemon, int level)
        {
            _pokemon = pokemon;
            _level = level;
        }

        public int GetMaxHp { get { return Mathf.FloorToInt((_pokemon.MaxHp * _level) / 100f) + 10; } }
        public int GetAttack { get { return Mathf.FloorToInt((_pokemon.Attack * _level) / 100f) + 5; } }
        public int GetDefense { get { return Mathf.FloorToInt((_pokemon.Defense * _level) / 100f) + 5; } }
        public int GetSpAttack { get { return Mathf.FloorToInt((_pokemon.SpAttack * _level) / 100f) + 5; } }
        public int GetSpDefense { get { return Mathf.FloorToInt((_pokemon.SpDefense * _level) / 100f) + 5; } }
        public int GetSpeed { get { return Mathf.FloorToInt((_pokemon.Speed * _level) / 100f) + 5; } }
    }
}
