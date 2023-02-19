using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Pokemon
{
    public class GetMove
    {
        public MovesModel Moves { get; set; }
        public int PP { get; set; }

        public GetMove(MovesModel moves)
        {
            Moves = moves;
            PP = moves.PP;
        }
    }
}
