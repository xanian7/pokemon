using Assets.Scripts.Pokemon;
using UnityEngine;

namespace Assets.Scripts.Models
{
    [CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]
    public class MovesModel
    {
        [SerializeField] string name;

        [TextArea]
        [SerializeField] string description;

        [SerializeField] PokemonTypes type;
        [SerializeField] int power;
        [SerializeField] int accuracy;
        [SerializeField] int pp;

        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public PokemonTypes Type { get { return type; } }
        public int Power { get { return power; } }
        public int Accuracy { get { return accuracy; } }
        public int PP { get { return pp; } }
    }
}
