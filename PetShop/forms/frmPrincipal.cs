using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

       
        private void mnuAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal frmAnimal = new frmCadAnimal();
            frmAnimal.MdiParent = this;
            frmAnimal.Show();
        }

        private void mnuCor_Click(object sender, EventArgs e)
        {
            frmCadCor frmCor = new frmCadCor();
            frmCor.MdiParent = this;
            frmCor.Show();
        }

        private void mnuFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnCadAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal frmAnimal = new frmCadAnimal();
            frmAnimal.MdiParent = this;
            frmAnimal.Show();
        }
    }
}
