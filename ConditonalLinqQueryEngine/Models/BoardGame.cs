using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConditonalLinqQueryEngine.Models
{
    public class BoardGame
    {
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public GameType GameType { get; set; }
        public int AverageGameTimeMinutes { get; set; }
        public int SuggestedMinimumAge { get; set; }
        public PlayType PlayType { get; set; }

        public BoardGame(string name, int maxPlayers, GameType type, int minutes, int age, PlayType playtype)
        {
            Name = name;
            MaxPlayers = maxPlayers;
            GameType = type;
            AverageGameTimeMinutes = minutes;
            SuggestedMinimumAge = age;
            PlayType = playtype;
        }
    }
}
