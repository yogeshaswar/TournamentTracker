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
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void textBoxPlaceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void buttonAddTeamMember_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("btn 1 clicked");
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {

        }

        private void buttonPerson_Click(object sender, EventArgs e)
        {
            if (ValidateFormFields()) {
                // TODO - Add People Model
                PersonModel model = new PersonModel(
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxEmail.Text,
                    textBoxCellphone.Text
                    );

                foreach (IDataConnection db in GlobalConfig.Connections) {
                    
                    db.CreatePerson(model);
                }


                MessageBox.Show("Success");
               
            } else
            {
                MessageBox.Show("Invalid Form Fields, Try again");
            }
        }

        private bool ValidateFormFields() {
            bool output = true;

            if (textBoxFirstName.Text == "") {
                output = false;

            }

            if (textBoxLastName.Text == "") {
                output = false;
            }

            if (textBoxEmail.Text == "") {
                output = false;
            }

            if (textBoxCellphone.Text == "") {
                output = false;
            }

            return output;
        }
    }
}
