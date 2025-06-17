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

        /// <summary>
        /// Gets or sets the unique identifier of the team competing in the event.
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summery>
        /// Represents one Team in the Matchup
        /// </summery>
        public TeamModel TeamCompeting { get; set; }

        /// <summery>
        /// Represents the score for the particular team
        /// </summery>
        public double Score { get; set; }

        /// <summary>
        /// Identifies the Matchup that this team came
        /// </summary>
        public int ParentMatchupId { get; set; }   

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
