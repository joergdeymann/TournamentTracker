using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker
{
    public static class TournamentLogic
    {
        // Order Teams List Randomly
        // Check if big enough, if not add byes=not to play this round (free up)
        // 2^4 Teams ?
        // Create First Round of Matchups
        // Create every Round after that 8 Matches , 4 -> 2 -> 1
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> teams = RandomizeTeamOrder(model.EnteredTeams);
        }
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

    }
}
