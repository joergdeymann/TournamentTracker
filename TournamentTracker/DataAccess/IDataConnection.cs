using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker.DataAccess
{
    public interface IDataConnection
    {
        PriceModel CreatePrice(PriceModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        List<TeamModel> GetTeam_All();

        List<PersonModel> GetPerson_All();

        // List<TournamentModel> GetTournament_All(TournamentModel model);
        List<TournamentModel> GetTournament_All();
    }
}
