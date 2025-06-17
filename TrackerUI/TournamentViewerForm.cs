using System.ComponentModel;
using System.Diagnostics;
using TournamentTracker.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = [];
        BindingList<MatchupModel> selectedMatchups = [];


        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            WireUpRoundList();
            WireUpMatchupList();
            LoadFormData();
            LoadRounds();
            Console.WriteLine("INIT TournamentViewer");
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }
        private void WireUpRoundList()
        {
            // Wire up the rounds list box
            //roundsBinding.DataSource = rounds;
            //roundDropdown.DataSource = roundsBinding;

            // roundDropdown.DataSource = null;
            // roundDropdown.DataSource = rounds;

            roundDropdown.DataSource = rounds;
            roundDropdown.DisplayMember = "RoundNumber"; // Assuming you have a property RoundNumber in your model

        }
        private void WireUpMatchupList()
        {
            // matchupListBox.DataSource = null;
            // matchupListBox.DataSource = selectedMatchups;
            //matchupsBinding.DataSource = selectedMatchups;
            //matchupListBox.DataSource = matchupsBinding;

            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName"; // Assuming you have a property MatchupName in your model
        }

        private void WireUpAllLists()
        {
            WireUpRoundList();
            WireUpMatchupList();
            // roundsBinding.ResetBindings(false);
            // matchupsBinding.ResetBindings(false);
        }

        private void LoadRounds()
        {
            // rounds = new BindingList<int>();
            rounds.Clear();
            rounds.Add(1);

            int currentRound = 1;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currentRound)
                {
                    currentRound = matchups.First().MatchupRound;
                    rounds.Add(currentRound);
                }
            }
            LoadMatchups(1); // Load the first round matchups by default
            // WireUpRoundList();
            // roundsBinding.ResetBindings(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Score Button clicked Form1_Load");

        }

        private void scoreButtonClickEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("#Score Button clicked");
            Console.WriteLine("#Score Button clicked");

        }

        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropdown.SelectedItem);
        }

        private void LoadMatchups(int  round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                }
            }
            // WireUpMatchupList();
            // matchupsBinding.ResetBindings(false);
            LoadMatchups(1);
        }


        private void LoadMatchup()
        {
            // if (matchupListBox.SelectedItem == null) return;
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    // if (m.Entries[i].TeamCompeting == null || m.Entries[1].TeamCompeting == null)
                    if (m.Entries[i].TeamCompeting == null)
                    {
                        teamOneLabel.Text = "Not Yet Determined";
                        scoreTeamOneText.Text = "";
                    }
                    else
                    {
                        teamOneLabel.Text = m.Entries[i].TeamCompeting.TeamName;
                        scoreTeamOneText.Text = m.Entries[i].Score.ToString();

                        teamTwoLabel.Text = "<bye>";
                        scoreTeamTwoText.Text = "0";
                    }

                }
                if (i == 1)
                {
                    if (m.Entries[i].TeamCompeting == null)
                    {
                        teamTwoLabel.Text = "Not Yet Determined";
                        scoreTeamTwoText.Text = "";
                    }
                    else
                    {
                        teamTwoLabel.Text = m.Entries[i].TeamCompeting.TeamName;
                        scoreTeamTwoText.Text = m.Entries[i].Score.ToString();
                    }

                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
    }
}
