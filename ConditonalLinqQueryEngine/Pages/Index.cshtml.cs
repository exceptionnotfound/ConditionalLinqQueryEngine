using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ConditonalLinqQueryEngine.Extensions;
using ConditonalLinqQueryEngine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ConditonalLinqQueryEngine.Pages
{
    public class IndexModel : PageModel
    {
        public List<BoardGame> Results { get; set; } = new List<BoardGame>();

        [BindProperty]
        public GameType SelectedGameType { get; set; }

        [BindProperty]
        [DisplayName("Search by Game Type")]
        public bool SearchByGameType { get; set; }

        [BindProperty]
        public int SelectedMinAge { get; set; }

        [BindProperty]
        [DisplayName("Search by Minimum Age")]
        public bool SearchByMinAge { get; set; }

        [BindProperty]
        public int SelectedPlayTime { get; set; }

        [BindProperty]
        [DisplayName("Search by Play Time")]
        public bool SearchByPlayTime { get; set; }

        [BindProperty]
        public int SelectedMaxPlayers { get; set; }

        [BindProperty]
        [DisplayName("Search by Max Players")]
        public bool SearchByMaxPlayers { get; set; }

        [BindProperty]
        public PlayType SelectedPlayType { get; set; }

        [BindProperty]
        [DisplayName("Search by Play Type")]
        public bool SearchByPlayType { get; set; }

        public IndexModel()
        {
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            BoardGameRepository repo = new BoardGameRepository();
            Results = repo.GetAll();

            Results = Results.If(SearchByGameType, q => q.Where(x => x.GameType == SelectedGameType))
                             .If(SearchByMinAge, q => q.Where(x => x.SuggestedMinimumAge >= SelectedMinAge))
                             .If(SearchByPlayTime, q=>q.Where(x => x.AverageGameTimeMinutes >= SelectedPlayTime))
                             .If(SearchByMaxPlayers, q => q.Where(x => x.MaxPlayers == SelectedMaxPlayers))
                             .If(SearchByPlayType, q => q.Where(x => x.PlayType == SelectedPlayType))
                             .ToList();
        }
    }
}
