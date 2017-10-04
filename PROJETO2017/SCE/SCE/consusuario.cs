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
    public partial class consusuario : Form
    {
        public consusuario()
        {
            InitializeComponent();
        }

        private void consusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGBDDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.sGBDDataSet.usuario);

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario frm = new usuario();
            frm.Show();
            Visible = false;
        }
    }
}
