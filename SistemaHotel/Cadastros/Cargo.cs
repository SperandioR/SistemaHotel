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
        }
        //Evento btnSalvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //aplicando uma condicional, convertendo o campo em uma string, e Trim()-remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
            {
                txtNome.Text = ""; //limpa o campo voltando o cursor para o inicio.
                MessageBox.Show("Preencha o Nome");  // msg de aviso.
                txtNome.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            btnNovo.Enabled = true;
        }
    }
}
