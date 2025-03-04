using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class ViewMatchDetails
    {
        public int MatchId { get; set; }
        public string FirstTeamName { get; set; }
        public string SecondTeamName { get; set; }
        public string? WinnerTeamName { get; set; }
        public string TournamentTitle { get; set; }
        public int ScoreFirstTeam { get; set; }
        public int ScoreSecondTeam { get; set; }
    }
}
