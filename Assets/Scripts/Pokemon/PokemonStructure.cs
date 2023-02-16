using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Models;
using Assets.Scripts.Pokemon;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new Pokemon")]
public class PokemonStructure : ScriptableObject
{
    [SerializeField] int ID;

    [SerializeField] string Name;

    [TextArea]
    [SerializeField] string Description;

    [SerializeField] Sprite Front;
    [SerializeField] Sprite Back;

    [SerializeField] PokemonTypes Type1;
    [SerializeField] PokemonTypes Type2;

    [SerializeField] int MaxHp;
    [SerializeField] int Attack;
    [SerializeField] int Defense;
    [SerializeField] int SpAttack;
    [SerializeField] int SpDefense;
    [SerializeField] int Speed;
    
}
