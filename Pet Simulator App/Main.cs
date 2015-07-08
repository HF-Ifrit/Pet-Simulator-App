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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewPet_Click(object sender, EventArgs e)
        {
            frmNewPet np = new frmNewPet(this);
            np.Show();
            Hide();
        }
    }
}
