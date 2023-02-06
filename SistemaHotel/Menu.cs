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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //Rendimensionando o menu 
        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //mantem maximizado a tela de Menu quando o mesmo for redimensionado.
        }
        //Submenu logount para logar da tela principal do Menu.
        private void logountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
