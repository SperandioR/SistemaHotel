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
        //Metodo para limpar o texto de cada campo: Enabled
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
            rbNome.Checked = true; //criando uma propriedade checked: Ao abrir O Menu Funcionários automaticamente o rbNome ficará ativado.
        }

        //alterando a visibilidade e o modo habilitado do campo txtBuscarCpf invisivel ao selecionar o rbNome.
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = " ";//desse modo os campos ficaram no modo string:representa palavras,frases ou textos
            txtBuscarCPF.Text = " ";
        }
        //Ao selecionar o campo rbCPF o campo txtBsucarNome ficará visil e o txtBuscarCPF ficará invisivel.
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();// criando uma chamada do Metodo: HabilitarCampos
            btnSalvar.Enabled = true;//o botão de salvar também ficará habilitado
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") //aplicando uma condicional caso o campo txtNome estiver vazio.
            {
                MessageBox.Show("Preencha o Nome");  // caixa de msg
                txtNome.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            if (txtCPF.Text == "") //aplicando uma condicional caso o campo txtCPF não esteja preenchido.
            {
                MessageBox.Show("Preencha o CPF");  // caixa de msg
                txtCPF.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }
        }
    }
}
