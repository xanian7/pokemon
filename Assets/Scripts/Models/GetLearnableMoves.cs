using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    [Serializable]
    public class GetLearnableMoves
    {
        [SerializeField] MovesModel moves;
        [SerializeField] int level;

        public MovesModel Moves { get { return moves; } }
        public int Level { get { return level; } }
    }
}
