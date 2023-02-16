using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class PokemonModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public Sprite frontSprite { get; set; }
        public Sprite backSprite { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int MaxHp { get; set; }
        public int Attack { get; set; }
        public int SpAttack { get; set; }
        public int Defense { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
    }
}
