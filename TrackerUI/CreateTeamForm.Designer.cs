namespace TrackerUI
{
    partial class CreateTeamForm
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
            createTeamLabel = new Label();
            teamNameComboBox = new ComboBox();
            teamNameLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberComboBox = new ComboBox();
            selectTeamMemberLabel = new Label();
            addMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeMembersButton = new Button();
            createTeamButton = new Button();
            addMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.BackColor = Color.Transparent;
            createTeamLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new Point(14, 9);
            createTeamLabel.Margin = new Padding(5, 0, 5, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(322, 74);
            createTeamLabel.TabIndex = 2;
            createTeamLabel.Text = "Create Team";
            // 
            // teamNameComboBox
            // 
            teamNameComboBox.FormattingEnabled = true;
            teamNameComboBox.Location = new Point(14, 162);
            teamNameComboBox.Name = "teamNameComboBox";
            teamNameComboBox.Size = new Size(763, 56);
            teamNameComboBox.TabIndex = 6;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.BackColor = Color.Transparent;
            teamNameLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(14, 114);
            teamNameLabel.Margin = new Padding(5, 0, 5, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(193, 45);
            teamNameLabel.TabIndex = 5;
            teamNameLabel.Text = "Team Name";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.BackColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamMemberButton.Location = new Point(247, 361);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(281, 78);
            addTeamMemberButton.TabIndex = 17;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = false;
            addTeamMemberButton.Click += AddTeamMemberButtonEvent;
            // 
            // selectTeamMemberComboBox
            // 
            selectTeamMemberComboBox.FormattingEnabled = true;
            selectTeamMemberComboBox.Location = new Point(14, 283);
            selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            selectTeamMemberComboBox.Size = new Size(763, 56);
            selectTeamMemberComboBox.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.BackColor = Color.Transparent;
            selectTeamMemberLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(14, 235);
            selectTeamMemberLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(324, 45);
            selectTeamMemberLabel.TabIndex = 15;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberGroupBox
            // 
            addMemberGroupBox.Controls.Add(createMemberButton);
            addMemberGroupBox.Controls.Add(phoneTextBox);
            addMemberGroupBox.Controls.Add(phoneLabel);
            addMemberGroupBox.Controls.Add(emailTextBox);
            addMemberGroupBox.Controls.Add(emailLabel);
            addMemberGroupBox.Controls.Add(lastNameTextBox);
            addMemberGroupBox.Controls.Add(lastNameLabel);
            addMemberGroupBox.Controls.Add(firstNameTextBox);
            addMemberGroupBox.Controls.Add(firstNameLabel);
            addMemberGroupBox.Location = new Point(14, 463);
            addMemberGroupBox.Name = "addMemberGroupBox";
            addMemberGroupBox.Size = new Size(763, 425);
            addMemberGroupBox.TabIndex = 18;
            addMemberGroupBox.TabStop = false;
            addMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.BackColor = Color.Silver;
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(233, 324);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(281, 78);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = false;
            createMemberButton.Click += CreateMemberButtonEvent;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 15F);
            phoneTextBox.Location = new Point(233, 250);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(517, 47);
            phoneTextBox.TabIndex = 20;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            phoneLabel.Location = new Point(13, 243);
            phoneLabel.Margin = new Padding(5, 0, 5, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(129, 54);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Phone";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 15F);
            emailTextBox.Location = new Point(233, 184);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(517, 47);
            emailTextBox.TabIndex = 18;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(13, 177);
            emailLabel.Margin = new Padding(5, 0, 5, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(128, 54);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "E-Mail";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 15F);
            lastNameTextBox.Location = new Point(233, 128);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(517, 47);
            lastNameTextBox.TabIndex = 16;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(13, 121);
            lastNameLabel.Margin = new Padding(5, 0, 5, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(201, 54);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 15F);
            firstNameTextBox.Location = new Point(233, 58);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(517, 47);
            firstNameTextBox.TabIndex = 14;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(8, 51);
            firstNameLabel.Margin = new Padding(5, 0, 5, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(203, 54);
            firstNameLabel.TabIndex = 13;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Segoe UI", 16F);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 45;
            teamMembersListBox.Location = new Point(836, 162);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(514, 724);
            teamMembersListBox.TabIndex = 19;
            // 
            // removeMembersButton
            // 
            removeMembersButton.BackColor = Color.Silver;
            removeMembersButton.FlatAppearance.BorderColor = Color.Silver;
            removeMembersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeMembersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeMembersButton.FlatStyle = FlatStyle.Flat;
            removeMembersButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            removeMembersButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeMembersButton.Location = new Point(1376, 463);
            removeMembersButton.Name = "removeMembersButton";
            removeMembersButton.Size = new Size(212, 154);
            removeMembersButton.TabIndex = 22;
            removeMembersButton.Text = "Remove Selected Members";
            removeMembersButton.UseVisualStyleBackColor = false;
            removeMembersButton.Click += RemoveSelectedMembersButtonEvent;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = Color.Silver;
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(636, 943);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(281, 78);
            createTeamButton.TabIndex = 22;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            createTeamButton.Click += CreateTeamButtonEvent;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1274);
            Controls.Add(createTeamButton);
            Controls.Add(removeMembersButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberComboBox);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameComboBox);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addMemberGroupBox.ResumeLayout(false);
            addMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private ComboBox teamNameComboBox;
        private Label teamNameLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberComboBox;
        private Label selectTeamMemberLabel;
        private GroupBox addMemberGroupBox;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Button createMemberButton;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private ListBox teamMembersListBox;
        private Button removeMembersButton;
        private Button createTeamButton;
    }
}