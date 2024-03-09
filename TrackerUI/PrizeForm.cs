using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class PrizeForm : Form
    {
        public PrizeForm()
        {
            InitializeComponent();
        }

        private void buttonCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateFormFields()) { 
                // Create PrizeModel with all the entered values
                PrizeModel model = new PrizeModel(
                    textBoxPlaceNumber.Text,
                    textBoxPlaceName.Text,
                    textBoxPrizeAmount.Text,
                    textBoxPrizePercentage.Text
                    );

                MessageBox.Show("Success");

                // Database

                foreach (IDataConnection db in GlobalConfig.Connections) {
                    db.CreatePrize(model);
                }

                ClearFormFields();

            } else
            {
                MessageBox.Show("Incorrect Form Fields, Try again");

            }
        }

        private void ClearFormFields()
        {
            textBoxPlaceNumber.Text = "";
            textBoxPlaceName.Text = "";
            textBoxPrizeAmount.Text = "";
            textBoxPrizePercentage.Text = "";
        }

        private bool ValidateFormFields()
        {
            bool output = true;
            int placeNumber = 0;
            // it'll take string input and try to convert it into int and assign that value to placeNumber
            bool placeNumberValidateNumer = int.TryParse(textBoxPlaceNumber.Text, out placeNumber);

            if (!placeNumberValidateNumer) { 
                output = false;
            }

            if (placeNumber < 1) 
            {
                output = false;
            }

            if (textBoxPlaceName.Text == "") {
                output = false;
            }

            decimal prizeAmount = 0;
            if (!decimal.TryParse(textBoxPrizeAmount.Text, out prizeAmount)) {
                output = false;   
            }

            double prizePercentage = 0;
            if (!double.TryParse(textBoxPrizePercentage.Text, out prizePercentage)) {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0) {
                output = false;
            }






            return output;
        }
    }
}
