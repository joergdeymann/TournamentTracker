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

namespace TrackerUI
{
    public partial class dashboardForm : Form
    {

        public dashboardForm()
        {
            InitializeComponent();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadTournamentButtonEvent(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("loadTournamentButtonEvent");
        }

        private void CreateTournamentButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("CreateTournamentButtonEvent");
        }
    }
}
