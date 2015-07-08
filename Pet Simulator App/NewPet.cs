using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Simulator_App
{
    //A form used to generate an instance of the pet class for the user to interact with
    public partial class frmNewPet : Form
    {
        //Form that causes the New Pet window to appear
        Form parentForm;

        public frmNewPet(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        /*Creates a new instance of the Pet class for the user.
        *Takes input from the text boxes on the form to intialize the pet stats
        */
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Store input
            string petName = txtNameInput.Text;
            int petHealth = int.Parse(txtHealthInput.Text);
            int petAttack = int.Parse(txtAttackInput.Text);
            int petDefense = int.Parse(txtDefenseInput.Text);

            //Create instance of a pet using user input
            Pet userPet = new Pet(petName, petHealth, petAttack, petDefense);

            //Show the Manager form to the user with their pet information
            frmManager petMan = new frmManager(userPet);
            Hide();
            petMan.Show();
        }

        /*Return back to the form that caused this window to appear (Should 
         *always be the main menu form)
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Close();
        }

        
    }
}
