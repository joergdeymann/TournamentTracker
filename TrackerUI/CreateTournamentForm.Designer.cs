namespace TrackerUI
{
    public partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void scoreTeamOneLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentNameDropdown = new ComboBox();
            entryFeeLabel = new Label();
            entryFeeText = new ComboBox();
            selectTeamDropdown = new ComboBox();
            selectTeamLabel = new Label();
            createTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPriceButton = new Button();
            playersLabel = new Label();
            tournamentTeamsListBox = new ListBox();
            removePlayersButton = new Button();
            removePriceButton = new Button();
            priceListBox = new ListBox();
            playersPriceLabel = new Label();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(14, 9);
            headerLabel.Margin = new Padding(5, 0, 5, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(478, 74);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.BackColor = Color.Transparent;
            tournamentNameLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(37, 109);
            tournamentNameLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(293, 45);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameDropdown
            // 
            tournamentNameDropdown.FormattingEnabled = true;
            tournamentNameDropdown.Location = new Point(37, 157);
            tournamentNameDropdown.Name = "tournamentNameDropdown";
            tournamentNameDropdown.Size = new Size(470, 53);
            tournamentNameDropdown.TabIndex = 4;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.BackColor = Color.Transparent;
            entryFeeLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(37, 238);
            entryFeeLabel.Margin = new Padding(5, 0, 5, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(179, 54);
            entryFeeLabel.TabIndex = 10;
            entryFeeLabel.Text = "Entry Fee";
            entryFeeLabel.Click += scoreTeamOneLabel_Click;
            // 
            // entryFeeText
            // 
            entryFeeText.FormattingEnabled = true;
            entryFeeText.Location = new Point(238, 239);
            entryFeeText.Name = "entryFeeText";
            entryFeeText.Size = new Size(146, 53);
            entryFeeText.TabIndex = 9;
            entryFeeText.Text = "0";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(37, 380);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(470, 53);
            selectTeamDropdown.TabIndex = 12;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.BackColor = Color.Transparent;
            selectTeamLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(37, 332);
            selectTeamLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(192, 45);
            selectTeamLabel.TabIndex = 11;
            selectTeamLabel.Text = "Select Team";
            // 
            // createTeamLink
            // 
            createTeamLink.AutoSize = true;
            createTeamLink.Location = new Point(311, 332);
            createTeamLink.Name = "createTeamLink";
            createTeamLink.Size = new Size(196, 45);
            createTeamLink.TabIndex = 13;
            createTeamLink.TabStop = true;
            createTeamLink.Text = "Create Team";
            createTeamLink.Click += CreateTeamLinkEvent;
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = Color.Silver;
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(161, 486);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(223, 78);
            addTeamButton.TabIndex = 14;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            addTeamButton.Click += AddTeamButtonClickEvent;
            // 
            // createPriceButton
            // 
            createPriceButton.BackColor = Color.Silver;
            createPriceButton.FlatAppearance.BorderColor = Color.Silver;
            createPriceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPriceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPriceButton.FlatStyle = FlatStyle.Flat;
            createPriceButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPriceButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPriceButton.Location = new Point(161, 585);
            createPriceButton.Name = "createPriceButton";
            createPriceButton.Size = new Size(223, 78);
            createPriceButton.TabIndex = 15;
            createPriceButton.Text = "Create Price";
            createPriceButton.UseVisualStyleBackColor = false;
            createPriceButton.Click += CreatePriceButtenEvent;
            // 
            // playersLabel
            // 
            playersLabel.AutoSize = true;
            playersLabel.BackColor = Color.Transparent;
            playersLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            playersLabel.Location = new Point(717, 109);
            playersLabel.Margin = new Padding(5, 0, 5, 0);
            playersLabel.Name = "playersLabel";
            playersLabel.Size = new Size(245, 45);
            playersLabel.TabIndex = 16;
            playersLabel.Text = "Teams / Players";
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 45;
            tournamentTeamsListBox.Location = new Point(717, 157);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(455, 229);
            tournamentTeamsListBox.TabIndex = 17;
            // 
            // removePlayersButton
            // 
            removePlayersButton.BackColor = Color.Silver;
            removePlayersButton.FlatAppearance.BorderColor = Color.Silver;
            removePlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removePlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removePlayersButton.FlatStyle = FlatStyle.Flat;
            removePlayersButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removePlayersButton.ForeColor = Color.FromArgb(51, 153, 255);
            removePlayersButton.Location = new Point(1205, 213);
            removePlayersButton.Name = "removePlayersButton";
            removePlayersButton.Size = new Size(223, 109);
            removePlayersButton.TabIndex = 18;
            removePlayersButton.Text = "Remove Team";
            removePlayersButton.UseVisualStyleBackColor = false;
            removePlayersButton.Click += RemoveTeamButtonEvent;
            // 
            // removePriceButton
            // 
            removePriceButton.BackColor = Color.Silver;
            removePriceButton.FlatAppearance.BorderColor = Color.Silver;
            removePriceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removePriceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removePriceButton.FlatStyle = FlatStyle.Flat;
            removePriceButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removePriceButton.ForeColor = Color.FromArgb(51, 153, 255);
            removePriceButton.Location = new Point(1205, 545);
            removePriceButton.Name = "removePriceButton";
            removePriceButton.Size = new Size(223, 106);
            removePriceButton.TabIndex = 21;
            removePriceButton.Text = "Remove Price";
            removePriceButton.UseVisualStyleBackColor = false;
            removePriceButton.Click += RemovePriceButtonEvent;
            // 
            // priceListBox
            // 
            priceListBox.FormattingEnabled = true;
            priceListBox.ItemHeight = 45;
            priceListBox.Location = new Point(717, 477);
            priceListBox.Name = "priceListBox";
            priceListBox.Size = new Size(455, 229);
            priceListBox.TabIndex = 20;
            // 
            // playersPriceLabel
            // 
            playersPriceLabel.AutoSize = true;
            playersPriceLabel.BackColor = Color.Transparent;
            playersPriceLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playersPriceLabel.ForeColor = Color.FromArgb(51, 153, 255);
            playersPriceLabel.Location = new Point(717, 429);
            playersPriceLabel.Margin = new Padding(5, 0, 5, 0);
            playersPriceLabel.Name = "playersPriceLabel";
            playersPriceLabel.Size = new Size(105, 45);
            playersPriceLabel.TabIndex = 19;
            playersPriceLabel.Text = "Prices";
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = Color.Silver;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(589, 754);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(321, 78);
            createTournamentButton.TabIndex = 22;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            createTournamentButton.Click += CreateTournamentButtonEvent;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1440, 887);
            Controls.Add(createTournamentButton);
            Controls.Add(removePriceButton);
            Controls.Add(priceListBox);
            Controls.Add(playersPriceLabel);
            Controls.Add(removePlayersButton);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(playersLabel);
            Controls.Add(createPriceButton);
            Controls.Add(addTeamButton);
            Controls.Add(createTeamLink);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeLabel);
            Controls.Add(entryFeeText);
            Controls.Add(tournamentNameDropdown);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private ComboBox tournamentNameDropdown;
        private Label entryFeeLabel;
        private ComboBox entryFeeText;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createTeamLink;
        private Button addTeamButton;
        private Button createPriceButton;
        private Label playersLabel;
        private ListBox tournamentTeamsListBox;
        private Button removePlayersButton;
        private Button removePriceButton;
        private ListBox priceListBox;
        private Label playersPriceLabel;
        private Button createTournamentButton;
    }
}