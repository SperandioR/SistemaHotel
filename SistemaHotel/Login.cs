using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin() //Construtor do e Inicialização do Formulário.
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }
        //Criando um evento do Frml-Load.
        private void FrmLogin_Load(object sender, EventArgs e)
        {     //calculando a centralização da tela de login sobre a tela de fundo do sistema.Obtendo o size 500 de W e H dividindo por 2.
            pnlLogin.Location = new Point(this.Width / 2 - 250, this.Height / 2 - 250); //Acessando a propriedade Location, gerando uma nova localização new Point.
            pnlLogin.Visible = true;
            /*btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0);*/ //Alterando a cor de seleção do Mouse ao clicar (RGB).
            /*btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0)*/
            btnLogin.ForeColor = Color.FromArgb(53, 36, 30);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Button de Login.
        private void button1_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }
        //criando um evento do tipo chave.
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                ChamarLogin();
            }
        }
        //criando um novo método de chamada ao apertar a tecla Enter.
        private void ChamarLogin()
        {
            if (txtUsuario.Text == "") //aplicando uma condicional
            {
                MessageBox.Show("Preencha o Usuário");  // caixa de msg
                txtUsuario.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            if (txtSenha.Text == "") //aplicando uma condicional
            {
                MessageBox.Show("Preencha a Senha");  // caixa de msg
                txtSenha.Focus(); //aplicando a propriedade Focus o usuário volta a receber o cursor do mouse.
                return;
            }

            //AQUI VAI O CÓDIGO PARA O LOGIN

            //Instanciando o objeto FrmMenu
            FrmMenu form = new FrmMenu(); // criando um objeto(form), da classe(FrmMenu) e instanciando(new FrmMenu).
            this.Hide(); // Ocutar o formulário de login e abre o formulário de Menu.
            form.Show(); //Inicialiando o menu formulário.
        }
    
    
    }
}
