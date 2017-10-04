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
    public partial class ConsCliente : Form
    {
        public ConsCliente()
        {
            InitializeComponent();
        }

        private void ConsCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGBDDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.sGBDDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'sGBDDataSet.tpveiculos'. Você pode movê-la ou removê-la conforme necessário.
            this.tpveiculosTableAdapter.Fill(this.sGBDDataSet.tpveiculos);

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcliente frm = new cadcliente();
            frm.Show();
            Visible = false;
        }
    }
}
