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
    public partial class DashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connections.GetTournament_All();
        public DashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        public void WireUpLists()
        {
            loadTournamentComboBox.DataSource = null;
            loadTournamentComboBox.DataSource = tournaments;
            loadTournamentComboBox.DisplayMember = "TournamentName";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadTournamentButtonEvent(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("loadTournamentButtonEvent");
            TournamentModel tm = (TournamentModel)loadTournamentComboBox.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }

        private void CreateTournamentButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("CreateTournamentButtonEvent");
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
            // TODO - Refresh the Tournament List on Dashboard
            // WireUpLists();
        }
    }
}
