using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConditonalLinqQueryEngine.Models
{
    public enum GameType
    {
        //Players play individiually, competing against other players
        Competitive,

        //Players play in teams, competing against other teams
        CompetitiveTeams,

        //All players work together to acheive a goal.
        Cooperative
    }
}
