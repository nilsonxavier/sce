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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gravar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            cod.Text = String.Empty;
            cod.Enabled = false;
            placaCarro.Text = String.Empty;
            placaCarro.Enabled = true;
            dataEntrada.Text = String.Empty;
            dataEntrada.Enabled = true;
            horaentrada.Text = String.Empty;
            horaentrada.Enabled = true;
            
            novo.Enabled = false;
            gravar.Enabled = true;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            placaCarro.Focus();
        }
    }
}
