using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;
using TournamentTracker.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPriceRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connections.GetTeam_All();
        List<TeamModel> selectedTeams = [];
        List<PriceModel> selectedPrices = [];
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            priceListBox.DataSource = null;
            priceListBox.DataSource = selectedPrices;
            priceListBox.DisplayMember = "PlaceName";

        }

        private void AddTeamButtonClickEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("#addTeamButton geklickt");

            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;
            // PriceModel p = (PriceModel)selectTeamDropdown.SelectedItem;
            if (t == null) return;
            availableTeams.Remove(t);
            selectedTeams.Add(t);
            // selectedPrices.Add(p);
            WireUpLists();
        }


        private void CreateTournamentButtonEvent(object sender, EventArgs e)
        {

            Debug.WriteLine("#CreateTournamentButtonEvent");
            // Validate Data
            bool feeAcceptable = decimal.TryParse(entryFeeText.Text,out decimal fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO - Create Tournament Model
            TournamentModel tm = new()
            {
                TournamentName = tournamentNameDropdown.Text,
                EntryFee = fee,
                Prices = selectedPrices,
                EnteredTeams = selectedTeams
            };
            // TODO - Create all Matches WireUp Matches
            // Order Teams List Randomly
            // Check if big enough, if not add byes=not to play this round (free up)
            // 2^4 Teams ?
            // Create First Round of Matchups
            // Create every Round after that 8 Matches , 4 -> 2 -> 1
            // 

            TournamentLogic.CreateRounds(tm);

            // Create Tournament
            GlobalConfig.Connections.CreateTournament(tm);


        }

        private void RemoveTeamButtonEvent(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t == null) return;
            availableTeams.Add(t);
            selectedTeams.Remove(t);
            WireUpLists();
        }

        private void RemovePriceButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("#DeletePriceButtonEvent");
            PriceModel p = (PriceModel)priceListBox.SelectedItem;
            if (p == null) return;
            // availablePrices.Add(p);
            // TODO - Here is missing deleting in database and Textfile

            selectedPrices.Remove(p);
            WireUpLists();

        }

        private void CreateTeamLinkEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("#CreateTeamLinkEvent");
            CreateTeamForm form = new CreateTeamForm(this);
            form.Show();

        }

        private void CreatePriceButtenEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("#CreatePriceButtenEvent");
            // Call the CreatePrice Form
            CreatePriceForm form = new(this);
            form.Show();

        }

        public void PriceComplete(PriceModel model)
        {
            // Get Back and get the Inputs
            selectedPrices.Add(model);
            WireUpLists();

        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

    }
}
