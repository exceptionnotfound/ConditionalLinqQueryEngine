using ConditonalLinqQueryEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConditonalLinqQueryEngine
{
    public class BoardGameRepository
    {
        public List<BoardGame> GetAll()
        {
            return new List<BoardGame>()
            {
                new BoardGame("Catan", 4, GameType.Competitive, 45, 10, PlayType.Strategy),
                new BoardGame("Candy Land", 4, GameType.Competitive, 30, 3, PlayType.Childrens),
                new BoardGame("Battleship", 2, GameType.Competitive, 30, 8, PlayType.Childrens),
                new BoardGame("Pandemic", 4, GameType.Cooperative, 45, 8, PlayType.Strategy),
                new BoardGame("Ticket to Ride", 4, GameType.Competitive, 30, 8, PlayType.Strategy),
                new BoardGame("Gloomhaven", 4, GameType.Cooperative, 60, 12, PlayType.Strategy),
                new BoardGame("Time's Up! Title Recall", 18, GameType.CompetitiveTeams, 60, 12, PlayType.Party),
                new BoardGame("Cards Against Humanity", 30, GameType.Competitive, 30, 17, PlayType.Party),
                new BoardGame("Azul", 4, GameType.Competitive, 30, 8, PlayType.Abstract),
                new BoardGame("Go", 2, GameType.Competitive, 75, 8, PlayType.Abstract),
                new BoardGame("Codenames", 8, GameType.Competitive, 15, 14, PlayType.Party),
                new BoardGame("Robinson Crusoe", 4, GameType.Cooperative, 90, 14, PlayType.Strategy),
                new BoardGame("Taboo", 10, GameType.CompetitiveTeams, 20, 12, PlayType.Party)
            };
        }
    }
}
