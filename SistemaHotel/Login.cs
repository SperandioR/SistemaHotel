using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //Criando um evento do Frml-Load.
        private void FrmLogin_Load(object sender, EventArgs e)
        {     //calculando a centralização da tela de login sobre a tela de fundo do sistema.Obtendo o size 500 de W e H dividindo por 2.
            pnlLogin.Location = new Point(this.Width / 2 - 250, this.Height / 2 - 250); //Acessando a propriedade Location, gerando uma nova localização new Point.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
