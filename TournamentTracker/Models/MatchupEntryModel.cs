using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique ID for the Matchup Entry
        /// </summary>
        public int Id { get; set; } 

        /// <summery>
        /// Represents one Team in the Matchup
        /// </summery>
        public TeamModel TeamCompeting { get; set; }

        /// <summery>
        /// Represents the score for the particular team
        /// </summery>
        public double Score { get; set; }

        /// <summery>
        /// Represents the matchup that this team came
        /// from as the winner
        /// </summery>
        public MatchupModel ParentMatchup { get; set; }

        /// <summery>
        /// Represents the matchup that this team came
        /// from as the winner
        /// </summery>
        /// <param name="initialScore">
        /// 	the initialScore
        /// </param>
        //public MatchupEntryModel(double initialScore)
        //{
        //    Console.WriteLine();
        //}
        
    }
}
