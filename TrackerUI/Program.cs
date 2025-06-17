namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Initialize db Connection
            // TournamentTracker.GlobalConfig.InitializeConnections(TournamentTracker.GlobalConfig.CONNECTION.FILE);
            TournamentTracker.GlobalConfig.InitializeConnections(TournamentTracker.GlobalConfig.CONNECTION.SQL);
            //& Application.Run(new CreateTournamentForm());
            // Application.Run(new CreatePriceForm());
            Application.Run(new DashboardForm());
        }
    }
}