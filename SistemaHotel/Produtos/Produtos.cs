using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Produtos
{
    public partial class FrmProtudos : Form
    {
        public FrmProtudos()
        {
            InitializeComponent();
        }

        //Metodo para habilitar os campo dentro do FrmProdutos.
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtEstoque.Enabled = true;
            cbFornecedor.Enabled = true;
            btnImagem.Enabled = true;
            txtNome.Focus(); //Quando habilitar os campos, ao clicar no btnNovo o Focus ficará ativo.
        }
        //Metodo para desabilitar os campos.
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            txtEstoque.Enabled = false;
            cbFornecedor.Enabled = false;
            btnImagem.Enabled = false;

        }
        //Metodo para limpar o texto de cada campo: Enabled
        private void limparCampos()
        {
            txtNome.Text = " ";
            txtDescricao.Text = " ";
            txtValor.Text = " ";
            txtEstoque.Text = " ";
            Limparfoto();

        }

        //criando metodo para carregar imagem padrão de fundo do PictureBox.
        private void Limparfoto()
        {
            img.Image = Properties.Resources.icons8_proibido_câmeras_100;
        }
        //metodo de chamada para limpar a foto dentro do FrmProdutos.
        private void FrmProtudos_Load(object sender, EventArgs e)
        {
            Limparfoto();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();// criando uma chamada do Metodo: HabilitarCampos
            btnSalvar.Enabled = true;//o botão de salvar também ficará habilitado
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
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

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtValor.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR.

            MessageBox.Show("Registro Salvo com Sucesso", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();//metodo para limpar todos os campos.
            desabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") //aplicando uma condicional, convertendo o campo em uma string, e Trim()-remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
            {
                txtNome.Text = ""; //limpa o campo voltando o cursor para o inicio.
                MessageBox.Show("Preencha o Nome", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtNome.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                txtValor.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR.

            MessageBox.Show("Registro Editado com Sucesso", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            limparCampos();//chamada para limpar todos os campos.
            desabilitarCampos();//chamada para desabilitar todos os campos.
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Deletar o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  // Metodo caixa de msg (1°Texto,2°titulo,3° Estilo da janela, 3°Icone)
            if (resultado == DialogResult.Yes)
            {

                //CÓDIGO DO BOTÃO DE DELETAR.

                MessageBox.Show("Registro Deletado com Sucesso", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);  // caixa de msg
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;

            }
        }
        //Criando filtros dentro da caixa de dialogos.
        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//exibir uma caixa de diálogo padrão que solicita ao usuário abrir um arquivo.
            dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();//criando uma variável do tipo string para extrair o caminho(FileName) do arquivo selecionado na caixa de dialogo(dialog) e passou a informação para a variável(foto). 
               img.ImageLocation = foto; //Obtem ou define um caminho ou URL para a imagem a ser exibida.
            }
        }
    }
}


