﻿using System;
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
        //Eventos
        //Rendimensionando o menu 
        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //mantem maximizado a tela de Menu quando o mesmo for redimensionado.
        }
        //Submenu logount para deslogar da tela principal do Menu.
        private void logountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(130, 130, 130);
        }
        //Criando um evento, referenciando a pasta cadastro FrmFuncionario e instaciando o mesmo.
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
            form.Show(); //abrir o formulário de funcionários.
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCargos form = new Cadastros.FrmCargos();
            form.Show(); //abrir o formulário de Cargos.
        }
        //Criando evento no Button Produtos, Instanciar e fazer uma chamada no FrmProdutos.
        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.FrmProtudos form = new Produtos.FrmProtudos();
            form.Show(); //abrir o formulário de Produtos.
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmProtudos form = new Produtos.FrmProtudos();
            form.Show(); //abrir o formulário de Produtos.
        }
    }
}
