using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdontologico
{
    public partial class FrmCadDentista : Form
    {
        DentistaService service = new DentistaService();

        public FrmCadDentista()
        {
            InitializeComponent();
            txtNome.Text = txtCelular.Text;
        }
        private string ValidarCad()
        {
            toolStripStatusMensagem.ForeColor = Color.Red;
            if(txtNome.Text == string.Empty)
            {
                return "Preencha campo Obrigatório!";
            }else if(txtCelular.Text == string.Empty)
            {
                return "Preencha campo Obrigatório!";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha campo Obrigatório!";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha campo Obrigatório";
            }
            else if (txtCRO.Text == string.Empty)
            {
                return "Preencha campo Obrigatório";
            }
            else
            {
                toolStripStatusMensagem.ForeColor = Color.Black;
                return "Preenchido com Sucesso!";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusMensagem.Text = ValidarCad();
                if(toolStripStatusMensagem.Text == "Preenchido com Sucesso!")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Cadastrado Efetuado com Sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex.Message);
            }
        }
        public Dentista objGerado()
        {
            Dentista objDentista = new Dentista();
            objDentista.Nome = txtNome.Text;
            objDentista.Email = txtEmail.Text;
            objDentista.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            objDentista.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            objDentista.CRO = txtCRO.Text;

            return objDentista;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConDentista frm = new FrmConDentista();
            frm.ShowDialog();
        }

       
        public void Limpar()
        {
            txtCelular.Text = String.Empty;
            txtCRO.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
