namespace TrackerUI
{
    public partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Label1_Click Header");
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneLabel = new Label();
            scoreTeamOneText = new ComboBox();
            scoreTeamOneLabel = new Label();
            scoreTeamTwoLabel = new Label();
            scoreTeamTwoText = new ComboBox();
            TeamTwoLabel = new Label();
            vsLabel = new Label();
            scoreButton = new Button();
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
            headerLabel.Size = new Size(310, 74);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.BackColor = Color.Transparent;
            tournamentName.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentName.Location = new Point(14, 83);
            tournamentName.Margin = new Padding(5, 0, 5, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(200, 67);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.BackColor = Color.Transparent;
            roundLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            roundLabel.Location = new Point(24, 168);
            roundLabel.Margin = new Padding(5, 0, 5, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(115, 45);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(178, 168);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(182, 49);
            roundDropdown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unplayedOnlyCheckbox.ForeColor = Color.FromArgb(51, 153, 255);
            unplayedOnlyCheckbox.Location = new Point(14, 223);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(350, 71);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "unplayed only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 41;
            matchupListBox.Location = new Point(12, 300);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(352, 248);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.BackColor = Color.Transparent;
            teamOneLabel.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneLabel.Location = new Point(570, 150);
            teamOneLabel.Margin = new Padding(5, 0, 5, 0);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(306, 67);
            teamOneLabel.TabIndex = 6;
            teamOneLabel.Text = "<Team One>";
            // 
            // scoreTeamOneText
            // 
            scoreTeamOneText.FormattingEnabled = true;
            scoreTeamOneText.Location = new Point(693, 224);
            scoreTeamOneText.Name = "scoreTeamOneText";
            scoreTeamOneText.Size = new Size(146, 49);
            scoreTeamOneText.TabIndex = 7;
            // 
            // scoreTeamOneLabel
            // 
            scoreTeamOneLabel.AutoSize = true;
            scoreTeamOneLabel.BackColor = Color.Transparent;
            scoreTeamOneLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreTeamOneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            scoreTeamOneLabel.Location = new Point(570, 217);
            scoreTeamOneLabel.Margin = new Padding(5, 0, 5, 0);
            scoreTeamOneLabel.Name = "scoreTeamOneLabel";
            scoreTeamOneLabel.Size = new Size(115, 54);
            scoreTeamOneLabel.TabIndex = 8;
            scoreTeamOneLabel.Text = "Score";
            scoreTeamOneLabel.Click += label1_Click_1;
            // 
            // scoreTeamTwoLabel
            // 
            scoreTeamTwoLabel.AutoSize = true;
            scoreTeamTwoLabel.BackColor = Color.Transparent;
            scoreTeamTwoLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreTeamTwoLabel.ForeColor = Color.FromArgb(51, 153, 255);
            scoreTeamTwoLabel.Location = new Point(570, 478);
            scoreTeamTwoLabel.Margin = new Padding(5, 0, 5, 0);
            scoreTeamTwoLabel.Name = "scoreTeamTwoLabel";
            scoreTeamTwoLabel.Size = new Size(115, 54);
            scoreTeamTwoLabel.TabIndex = 11;
            scoreTeamTwoLabel.Text = "Score";
            // 
            // scoreTeamTwoText
            // 
            scoreTeamTwoText.FormattingEnabled = true;
            scoreTeamTwoText.Location = new Point(693, 485);
            scoreTeamTwoText.Name = "scoreTeamTwoText";
            scoreTeamTwoText.Size = new Size(146, 49);
            scoreTeamTwoText.TabIndex = 10;
            // 
            // TeamTwoLabel
            // 
            TeamTwoLabel.AutoSize = true;
            TeamTwoLabel.BackColor = Color.Transparent;
            TeamTwoLabel.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamTwoLabel.Location = new Point(570, 411);
            TeamTwoLabel.Margin = new Padding(5, 0, 5, 0);
            TeamTwoLabel.Name = "TeamTwoLabel";
            TeamTwoLabel.Size = new Size(300, 67);
            TeamTwoLabel.TabIndex = 9;
            TeamTwoLabel.Text = "<Team Two>";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.BackColor = Color.Transparent;
            vsLabel.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vsLabel.ForeColor = Color.FromArgb(51, 153, 255);
            vsLabel.Location = new Point(693, 324);
            vsLabel.Margin = new Padding(5, 0, 5, 0);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(111, 67);
            vsLabel.TabIndex = 12;
            vsLabel.Text = "-vs-";
            // 
            // scoreButton
            // 
            scoreButton.BackColor = Color.Silver;
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            scoreButton.Location = new Point(958, 324);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(190, 78);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = false;
            scoreButton.Click += scoreButtonClickEvent;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1192, 738);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(scoreTeamTwoLabel);
            Controls.Add(scoreTeamTwoText);
            Controls.Add(TeamTwoLabel);
            Controls.Add(scoreTeamOneLabel);
            Controls.Add(scoreTeamOneText);
            Controls.Add(teamOneLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneLabel;
        private ComboBox scoreTeamOneText;
        private Label scoreTeamOneLabel;
        private Label scoreTeamTwoLabel;
        private ComboBox scoreTeamTwoText;
        private Label TeamTwoLabel;
        private Label vsLabel;
        private Button scoreButton;
    }
}
