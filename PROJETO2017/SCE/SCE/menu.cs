﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCE
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void tiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrotipoveiculos frm = new cadastrotipoveiculos();
            frm.Show();
        }

        private void corDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrocorveiculos frm = new cadastrocorveiculos();
            frm.Show();
        }

        private void tamanhoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadtamanho frm = new cadtamanho();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcliente frm = new cadcliente();
            frm.Show();
        }

        private void utilitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario frm = new usuario();
            frm.Show();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conf frm = new conf();
            frm.Show();
        }
    }
}
