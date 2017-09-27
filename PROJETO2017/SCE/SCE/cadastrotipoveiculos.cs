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
    public partial class cadastrotipoveiculos : Form
    {
        //string de Conexão
        SqlConnection conn = new SqlConnection("Data Source=WISLEY-PC;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public cadastrotipoveiculos()
        {
            InitializeComponent();
            
        }

        private void cadastrotipoveiculos_Load(object sender, EventArgs e)
        {
            
            codigo.Enabled = true;
            tipo.Enabled = false;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            codigo.Text = String.Empty;
            tipo.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo.Text = String.Empty;
            tipo.Text = String.Empty;
            tipo.Enabled = true;
            novo.Enabled = false;
            gravar.Enabled = true;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            codigo.Enabled = false;
            tipo.Focus();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if(codigo.Text != "")
            {
                codigo.Focus();
                codigo.Enabled = true;
                novo.Enabled = true;
                gravar.Enabled = false;
                excluir.Enabled = true;
                cancelar.Enabled = false;
                codigo.Focus();
                tipo.Enabled = false;
                codigo.Text = String.Empty;
                tipo.Text = String.Empty;
            }
            else
            {
                codigo.Focus();
                codigo.Enabled = true;
                novo.Enabled = true;
                gravar.Enabled = false;
                excluir.Enabled = true;
                cancelar.Enabled = false;
                codigo.Focus();
                tipo.Enabled = false;
                codigo.Text = String.Empty;
                tipo.Text = String.Empty;
            }
                          

        }

        private void excluir_Click(object sender, EventArgs e)
                
        {
            //Excluir tipo de veiculos
            String x = "";
            conn.Open();
            comando.CommandText = "select * FROM tpveiculos where codigo='" + codigo.Text + "'";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    x = dr[0].ToString();
                }

            }
            conn.Close();
            if (x != "")
            {
                conn.Open();
                comando.CommandText = "DELETE FROM tpveiculos where codigo='" + codigo.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tipo de Veiculo Excluido com Sucesso!");
            }
            else if (codigo.Text == "")
            {
                MessageBox.Show("Prencha o Dados do Campo Codigo!");
                codigo.Focus();

            }
            else
            {
                MessageBox.Show("Dados do Cmapo Codigo Invalidos!");
                codigo.Focus();
            }  
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            if (tipo.Text == "")
            {
                MessageBox.Show("O campo Tipo não pode estar Vazio, Erro Ao Salvar!");
                tipo.Focus();
                return;
            }
            else
            {
                conn.Open();

                comando.CommandText = "INSERT INTO tpveiculos (tipo) values ('" + tipo.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                codigo.Text = String.Empty;
                tipo.Text = String.Empty;
                codigo.Enabled = true;
                tipo.Enabled = false;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;

            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void consultarTiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultipoveic frm = new consultipoveic();
            frm.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
