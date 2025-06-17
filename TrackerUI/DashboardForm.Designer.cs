namespace TrackerUI
{
    partial class DashboardForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dashboardLabel = new Label();
            loadTournamentComboBox = new ComboBox();
            loadLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.BackColor = Color.Transparent;
            dashboardLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = Color.FromArgb(51, 153, 255);
            dashboardLabel.Location = new Point(115, 9);
            dashboardLabel.Margin = new Padding(5, 0, 5, 0);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(553, 74);
            dashboardLabel.TabIndex = 3;
            dashboardLabel.Text = "Tournment Dashboard";
            // 
            // loadTournamentComboBox
            // 
            loadTournamentComboBox.FormattingEnabled = true;
            loadTournamentComboBox.Location = new Point(115, 151);
            loadTournamentComboBox.Name = "loadTournamentComboBox";
            loadTournamentComboBox.Size = new Size(553, 53);
            loadTournamentComboBox.TabIndex = 8;
            // 
            // loadLabel
            // 
            loadLabel.AutoSize = true;
            loadLabel.BackColor = Color.Transparent;
            loadLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadLabel.ForeColor = Color.FromArgb(51, 153, 255);
            loadLabel.Location = new Point(187, 103);
            loadLabel.Margin = new Padding(5, 0, 5, 0);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(399, 45);
            loadLabel.TabIndex = 7;
            loadLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.BackColor = Color.Silver;
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            loadTournamentButton.Location = new Point(208, 250);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(341, 78);
            loadTournamentButton.TabIndex = 18;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = false;
            loadTournamentButton.MouseClick += LoadTournamentButtonEvent;
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
            createTournamentButton.Location = new Point(208, 352);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(341, 78);
            createTournamentButton.TabIndex = 19;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            createTournamentButton.Click += CreateTournamentButtonEvent;
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(822, 523);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadTournamentComboBox);
            Controls.Add(loadLabel);
            Controls.Add(dashboardLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "dashboardForm";
            Text = "Dashboard";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardLabel;
        private ComboBox loadTournamentComboBox;
        private Label loadLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}