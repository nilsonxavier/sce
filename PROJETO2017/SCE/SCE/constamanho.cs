using System;
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
    public partial class constamanho : Form
    {
        public constamanho()
        {
            InitializeComponent();
        }

        private void constamanho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGBDDataSet.tptamanho'. Você pode movê-la ou removê-la conforme necessário.
            this.tptamanhoTableAdapter.Fill(this.sGBDDataSet.tptamanho);

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadtamanho frm = new cadtamanho();
            frm.Show();
            Visible = false;
        }
    }
}
