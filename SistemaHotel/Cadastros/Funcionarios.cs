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
            txtNome.Focus(); //Quando habilitar os campos, ao clicar no btnNovo o Focus ficará ativo.
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
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //aplicando uma condicional, convertendo o campo em uma string, e Trim()-remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
            {
                txtNome.Text = ""; //limpa o campo voltando o cursor para o inicio.
                MessageBox.Show("Preencha o Nome", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtNome.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtCPF.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR.

            MessageBox.Show("Registro Salvo com Sucesso", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();//metodo para limpar todos os campos.
            desabilitarCampos();
        }
    }
}
