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
    public partial class consultarcor : Form
    {
        public consultarcor()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrocorveiculos frm = new cadastrocorveiculos();
            frm.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void consultarcor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGBDDataSet.tpcor'. Você pode movê-la ou removê-la conforme necessário.
            this.tpcorTableAdapter.Fill(this.sGBDDataSet.tpcor);

        }
    }
}
