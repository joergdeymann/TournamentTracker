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
            int rounds = FindNumberOfRounds(teams.Count);
            int byes = NumberOfByes(rounds,teams.Count);
            model.Rounds.Add(CreateFirstRound(byes, teams));
            createOtherRounds(model, rounds);

        }

        private static List<MatchupModel> CreateFirstRound(int byes,List<TeamModel> teams)
        {
            List<MatchupModel> output = [];
            MatchupModel m = new();
            foreach (TeamModel t in teams)
            {
                m.Entries.Add(new MatchupEntryModel { TeamCompeting = t });
                if (byes > 0 || m.Entries.Count > 1)
                {
                    m.MatchupRound = 1;
                    output.Add(m);
                    m = new MatchupModel(); // Start a new matchup for the next team
                    if (byes > 0)
                    {
                        byes--; // Decrease the bye count
                    }
                }
            }
            return output;
        }

        private static void createOtherRounds(TournamentModel model,int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currentRound = [];
            MatchupModel currentMatchup = new();

            while (round <= rounds)
            {
                foreach (MatchupModel m in previousRound)
                {
                    currentMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = m });
                    if (currentMatchup.Entries.Count > 1)
                    {
                        currentMatchup.MatchupRound = round;
                        currentRound.Add(currentMatchup);
                        currentMatchup = new MatchupModel(); // Start a new matchup for the next entry
                    }
                }

                model.Rounds.Add(currentRound);
                previousRound = currentRound; // Move to the next round
                currentRound = new();
                round += 1;
            }


        }

        private static int NumberOfByes(int rounds, int teamCount)
        {
            int output = 0;
            int totalTeams = 1;
            for (int i = 0; i < rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - teamCount;
            return output;
        }
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 0;
            int value = 1;
            while (value < teamCount)
            {
                value *= 2;
                output += 1;
            }
            return output;
        }   

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList(); // Guid.NewGuid() gives a unique random value for each item
        }

    }
}
