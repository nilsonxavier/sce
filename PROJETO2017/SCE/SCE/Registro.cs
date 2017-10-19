using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCE
{
    public partial class Registro : Form
    {
        //string de Conexão
        SqlConnection conn = new SqlConnection("Data Source=wisley-pc;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        
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
            String x = "";
            String y = "";
            String z = "";
            if (placaCarro.Text == "")
            {
                MessageBox.Show("O campo Placa não pode estar Vazio, Erro Ao Salvar!");
                placaCarro.Focus();
                return;
            }
            else if (comboBox2.Text == "")//configuração tipo de veiculos
            {

                MessageBox.Show("O campo Tipo de Veiculos não pode estar Vazio, Erro Ao Salvar!");
                comboBox2.Focus();
                return;
                conn.Open();
                comando.CommandText = "select * FROM tpveiculos where tipo='" + comboBox2.Text + "'";
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        x = dr[1].ToString();
                        
                    }
                }

                conn.Close();
            }
            else if (x != "")
            {
                MessageBox.Show("O campo Tipo de Veiculos diferente do cadastrado, Erro Ao Salvar!");
                comboBox2.Focus();
                return;
            }
            else if (comboBox4.Text == "")//configuração categoria
            {
                MessageBox.Show("O campo Categoria não pode estar Vazio, Erro Ao Salvar!");
                comboBox4.Focus();
                return;
                conn.Open();
                comando.CommandText = "select * FROM categoria where modelo='" + comboBox4.Text + "'";
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        comboBox2.Text = dr[1].ToString();

                    }
                }
                
            }
            else if (y != "")
            {
                MessageBox.Show("O campo Categoria diferente do cadastrado, Erro Ao Salvar!");
                comboBox4.Focus();
                return;
            }
            
            else if (comboBox3.Text == "")//configuração cor
            {
                MessageBox.Show("O campo Cor não pode estar Vazio, Erro Ao Salvar!");
                comboBox3.Focus();
                return;
                conn.Open();
                comando.CommandText = "select * FROM tpcor where cor='" + comboBox3.Text + "'";
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        z = dr[1].ToString();

                    }
                }
                
                conn.Close();
            }else if (z != "")
            {
                MessageBox.Show("O campo cor diferente do cadastrado, Erro Ao Salvar!");
                comboBox3.Focus();
                return;
            }
            else if (dataEntrada.Text == "")
            {
                MessageBox.Show("O campo Data não pode estar Vazio, Erro Ao Salvar!");
                dataEntrada.Focus();
                return;
            }
            else if (horaentrada.Text == "")
            {
                MessageBox.Show("O campo Hora não pode estar Vazio, Erro Ao Salvar!");
                horaentrada.Focus();
                return;
            }
            else
            {
                conn.Open();

                comando.CommandText = "INSERT INTO registro (placa,tpveiculos,categoria,cor,dataentrada,horaentrada) values ('" + placaCarro.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + comboBox3.Text + "','" + dataEntrada.Text + "','" + horaentrada.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                cod.Enabled = true;
                cod.Text = String.Empty;
                placaCarro.Enabled = false;
                placaCarro.Text = String.Empty;
                comboBox2.Enabled = false;
                comboBox2.Text = String.Empty;
                comboBox4.Enabled = false;
                comboBox4.Text = String.Empty;
                comboBox3.Enabled = false;
                comboBox3.Text = String.Empty;
                dataEntrada.Enabled = false;
                dataEntrada.Text = String.Empty;
                horaentrada.Enabled = false;
                horaentrada.Text = String.Empty;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
                
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
            cod.Enabled = false;
            cod.Text = String.Empty;
            placaCarro.Enabled = true;
            placaCarro.Text = String.Empty;
            comboBox2.Enabled = true;
            comboBox2.Text = String.Empty;
            comboBox4.Enabled = true;
            comboBox4.Text = String.Empty;
            comboBox3.Enabled = true;
            comboBox3.Text = String.Empty;
            dataEntrada.Enabled = false;
            horaentrada.Enabled = false;
            novo.Enabled = false;
            gravar.Enabled = true;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            dataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            horaentrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            cod.Enabled = true;
            cod.Text = String.Empty;
            placaCarro.Enabled = false;
            placaCarro.Text = String.Empty;
            comboBox2.Enabled = false;
            comboBox2.Text = String.Empty;
            comboBox4.Enabled = false;
            comboBox4.Text = String.Empty;
            comboBox3.Enabled = false;
            comboBox3.Text = String.Empty;
            dataEntrada.Enabled = false;
            dataEntrada.Text = String.Empty;
            horaentrada.Enabled = false;
            horaentrada.Text = String.Empty;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechar_Click(object sender, EventArgs e)
        {

        }

        private void excluir_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
