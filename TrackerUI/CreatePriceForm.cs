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
using TournamentTracker.DataAccess;
using TournamentTracker.Models;

namespace TrackerUI
{
    public partial class CreatePriceForm : Form
    {
        IPriceRequester callingForm;
        public CreatePriceForm(IPriceRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void CreatePriceButtonEvent(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PriceModel model = new(
                    placeNameTextBox.Text,
                    placeNumberTextBox.Text,
                    priceAmountTextBox.Text,
                    pricePercentageTextBox.Text
                );
                GlobalConfig.Connections.CreatePrice(model);

                callingForm.PriceComplete(model);
                this.Close();


                //placeNameTextBox.Text = "";
                //placeNumberTextBox.Text = "";
                //priceAmountTextBox.Text = "0";
                //pricePercentageTextBox.Text = "0";

                //MessageBox.Show("Price is generated successfull");

            }
            else
            {
                MessageBox.Show("You entrered something wrong or missed something ! Try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            bool validPlaceNumber = int.TryParse(placeNumberTextBox.Text, out int placeNumber);
            bool validPriceAmount = decimal.TryParse(priceAmountTextBox.Text, out decimal priceAmount);
            bool validPricePercentage = double.TryParse(pricePercentageTextBox.Text, out double pricePercentage);

            if (!validPlaceNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameTextBox.Text.Length < 1)
            {
                output = false;
            }
            if (!validPriceAmount)
            {
                output = false;
            }
            if (!validPriceAmount || !validPricePercentage)
            {
                output = false;
            }

            if (priceAmount <= 0 && pricePercentage <= 0)
            {
                output = false;
            }

            if (pricePercentage < 0 || pricePercentage > 100)
            {
                output = false;
            }

            return output;
        }

    }
}
