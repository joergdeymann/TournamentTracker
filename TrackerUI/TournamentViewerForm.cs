using System.Diagnostics;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        public TournamentViewerForm()
        {
            InitializeComponent();
            Console.WriteLine("INIT TournamentViewer");
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
    }
}
