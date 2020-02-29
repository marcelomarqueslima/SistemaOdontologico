using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdontologico
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuCadDentista_Click(object sender, EventArgs e)
        {
            FrmCadDentista frm = new FrmCadDentista();
            frm.ShowDialog();
        }

        private void menuCadPaciente_Click(object sender, EventArgs e)
        {
            FrmPaciente frm = new FrmPaciente();
            frm.ShowDialog();
        }

        private void menuCadConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta frm = new FrmConsulta();
            frm.ShowDialog();
        }

        private void menuAgDentista_Click(object sender, EventArgs e)
        {
           // Hide();
            FrmConDentista frm = new FrmConDentista();
            frm.ShowDialog();
        }
    }
}
