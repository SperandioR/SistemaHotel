using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        //Metodo para habilitar os campo dentro do FrmFuncionarios.
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtTel.Enabled = true;
            txtEndereco.Enabled = true;
            cbCargo.Enabled = true;
        }
        //Metodo para desabilitar os campos.
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtTel.Enabled = false;
            txtEndereco.Enabled = false;
            cbCargo.Enabled = false;

        }
        //Metodo para limpar o texto de cada campo.Enabled
        private void limparCampos()
        {
            txtNome.Text = " ";
            txtCPF.Text = " ";
            txtTel.Text = " ";
            txtEndereco.Text = " ";
        }
        //Eventos
        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true; //criando uma propriedade checked.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        //alterando a visibilidade e o modo habilitado do campo txtBuscarCpf invisivel.
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = " ";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;
        }
    }
}
