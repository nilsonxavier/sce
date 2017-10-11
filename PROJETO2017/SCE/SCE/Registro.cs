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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gravar_Click(object sender, EventArgs e)
        {
            if (placaCarro.Text == "")
            {
                MessageBox.Show("O campo Placa não pode estar Vazio, Erro Ao Salvar!");
                placaCarro.Focus();
                return;
            }
            if (horaentrada.Text == "")
            {
                MessageBox.Show("O campo Hora Entrada não pode estar Vazio, Erro Ao Salvar!");
                horaentrada.Focus();
                return;
            }
            if (dataEntrada.Text == "")
            {
                MessageBox.Show("O campo data de entrada não pode estar Vazio, Erro Ao Salvar!");
                dataEntrada.Focus();
                return;
            }
            else
            {
                /*
                conn.Open();

                comando.CommandText = "INSERT INTO entrada (nome,cpf,endereco,n,telefone,email) values ('" + nome.Text + "','" + cpf.Text + "','" + endereco.Text + "','" + n.Text + "','" + telefone.Text + "','" + email.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                codigo.Text = String.Empty;
                nome.Text = String.Empty;
                cpf.Enabled = false;
                telefone.Enabled = false;
                email.Enabled = false;
                endereco.Enabled = false;
                n.Enabled = false;
                cpf.Text = String.Empty;
                telefone.Text = String.Empty;
                email.Text = String.Empty;
                endereco.Text = String.Empty;
                n.Text = String.Empty;
                nome.Enabled = false;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
                codigo.Enabled = true;
                codigo.Focus();
                conn.Close();
                */
            }
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

        private void cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
