using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TournamentTracker;
using TournamentTracker.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private ITeamRequester callingForm;
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = [];
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            // CreateSampleData();
            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void WireUpLists()
        {
            selectTeamMemberComboBox.DataSource = null;
            selectTeamMemberComboBox.DataSource = availableTeamMembers.OrderBy(o => o.FirstName).ThenBy(o => o.LastName).ToList();
            selectTeamMemberComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers.OrderBy(o => o.FirstName).ThenBy(o => o.LastName).ToList();
            teamMembersListBox.DisplayMember = "FullName";
        }
        private void AddTeamMemberButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("AddTeamMemberButtonEvent");
            PersonModel p = (PersonModel)selectTeamMemberComboBox.SelectedItem;
            if (p == null) return;
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);
            WireUpLists();
        }

        private void CreateMemberButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("CreateMemberButtonEvent");
            if (ValidateForm())
            {
                PersonModel p = new()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    CellPhoneNumber = phoneTextBox.Text,
                    EmailAddress = emailTextBox.Text
                };

                p = GlobalConfig.Connections.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";

                MessageBox.Show("Team Member is generated successfull");


            }
            else
            {
                MessageBox.Show("All 4 Fields have to be filled!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            bool validFirstName = firstNameTextBox.Text.Trim() != "";
            bool validLastName = lastNameTextBox.Text.Trim() != "";
            bool validPhone = phoneTextBox.Text.Trim() != "";
            bool validEmail = emailTextBox.Text.Trim() != "";


            if (!validFirstName)
            {
                output = false;
            }
            if (!validLastName)
            {
                output = false;
            }
            if (!validPhone)
            {
                output = false;
            }
            if (!validEmail)
            {
                output = false;
            }
            return output;


        }
        private void CreateTeamButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("CreateTeamButtonEvent");
            TeamModel t = new()
            {
                TeamName = teamNameComboBox.Text,
                TeamMembers = selectedTeamMembers
            };
            GlobalConfig.Connections.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();
        }

        private void RemoveSelectedMembersButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("DeleteSelectedMembersButtonEvent");
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p == null) return;
            availableTeamMembers.Add(p);
            selectedTeamMembers.Remove(p);
            WireUpLists();

        }

    }
}
