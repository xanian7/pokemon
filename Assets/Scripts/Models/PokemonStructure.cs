using UnityEngine;
using Assets.Scripts.Pokemon;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new Pokemon")]
public class PokemonStructure : ScriptableObject
{
    [SerializeField] int id;

    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite front;
    [SerializeField] Sprite back;

    [SerializeField] PokemonTypes type1;
    [SerializeField] PokemonTypes type2;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public int ID { get { return id; } }
    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public Sprite Front { get { return front; } }
    public Sprite Back { get { return back; } }
    public PokemonTypes Type1 { get { return type1; } }
    public PokemonTypes Type2 { get { return type2; } }
    public int MaxHp { get { return maxHp; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int SpAttack { get { return spAttack; } }
    public int SpDefense { get { return spDefense; } }
    public int Speed { get { return speed; } }
}
