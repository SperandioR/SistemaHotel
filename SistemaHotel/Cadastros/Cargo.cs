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
    public partial class FrmCargos : Form
    {
        public FrmCargos()
        {
            InitializeComponent();
        }
        //Criando um evento para o button novo e habilitando o campo txtNome e o btnSalvar ao clicar no btnNovo.

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true; //Criando "METODO" para habilitar os campos txtNome e btnSalvar o clicar no btnNovo.
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            txtNome.Focus();
        }
        //Evento btnSalvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //aplicando uma condicional, convertendo o campo em uma string, e Trim()-remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
            {
                txtNome.Text = ""; //limpa o campo voltando o cursor para o inicio.
                MessageBox.Show("Preencha o Cargo", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtNome.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }
            //MSG confirmando que o registro foi salvo.
            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
            txtNome.Focus();

        }

        private void grid_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //aplicando uma condicional, convertendo o campo em uma string, e Trim()-remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
            {
                txtNome.Text = ""; //limpa o campo voltando o cursor para o inicio.
                MessageBox.Show("Preencha o Cargo", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtNome.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR.

            MessageBox.Show("Registro Editado com Sucesso", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }
        //Evento do botão deletar 
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Deletar o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  // Metodo caixa de msg (1°Texto,2°titulo,3° Estilo da janela, 3°Icone)
            if (resultado == DialogResult.Yes)
            {
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Clicou em sim");
                }
            }

        }
    }
}
