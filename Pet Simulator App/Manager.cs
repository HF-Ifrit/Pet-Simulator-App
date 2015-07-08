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
    //A form used to interact with the user's created pet
    public partial class frmManager : Form
    {
        public frmManager(Pet userPet)
        {
            InitializeComponent();
            lblNameDisplay.Text = userPet.getName();
            lblHealthDisplay.Text = Convert.ToString(userPet.getStats().getHealth()) + "/" +
                Convert.ToString(userPet.getStats().getMaxHealth());
            lblAttackDisplay.Text = Convert.ToString(userPet.getStats().getAttack());
            lblDefenseDisplay.Text = Convert.ToString(userPet.getStats().getDefense());
        }
    }
}
