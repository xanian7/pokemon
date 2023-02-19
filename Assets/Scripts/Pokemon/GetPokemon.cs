using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Pokemon
{
    public class GetPokemon
    {
        PokemonModel _model;
        int _level;
        
        public int HP { get; set; }
        public List<GetMove> Moves { get; set; }
        public GetPokemon(PokemonModel model, int level)
        {
            _model = model;
            _level = level;
            HP = _model.MaxHp;

            Moves = new List<GetMove>();
            foreach (var move in _model.LearnableMoves)
            {
                if (move.Level <= level)
                {
                    Moves.Add(new GetMove(move.Moves));
                }
                if (Moves.Count > 4)
                {
                    break;
                }
            }
        }
        public PokemonModel Model { get { return _model; } }

        public int GetMaxHp { get { return Mathf.FloorToInt((_model.MaxHp * _level) / 100f) + 10; } }
        public int GetAttack { get { return Mathf.FloorToInt((_model.Attack * _level) / 100f) + 5; } }
        public int GetDefense { get { return Mathf.FloorToInt((_model.Defense * _level) / 100f) + 5; } }
        public int GetSpAttack { get { return Mathf.FloorToInt((_model.SpAttack * _level) / 100f) + 5; } }
        public int GetSpDefense { get { return Mathf.FloorToInt((_model.SpDefense * _level) / 100f) + 5; } }
        public int GetSpeed { get { return Mathf.FloorToInt((_model.Speed * _level) / 100f) + 5; } }
    }
}
