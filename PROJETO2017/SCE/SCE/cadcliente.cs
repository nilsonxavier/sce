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
    public partial class cadcliente : Form
    {
        //string de Conexão
        SqlConnection conn = new SqlConnection("Data Source=wisley-pc;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public cadcliente()
        {
            InitializeComponent();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            codigo.Text = String.Empty;
            nome.Text = String.Empty;
            cpf.Enabled = true;
            telefone.Enabled = true;
            email.Enabled = true;
            endereco.Enabled = true;
            n.Enabled = true;
            cpf.Text = String.Empty;
            telefone.Text = String.Empty;
            email.Text = String.Empty;
            endereco.Text = String.Empty;
            n.Text = String.Empty;
            nome.Enabled = true;
            novo.Enabled = false;
            gravar.Enabled = true;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            codigo.Enabled = false;
            cpf.Focus();
        }

        private void cadcliente_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
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
        }

        private void fechar_Click(object sender, EventArgs e)
        {
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
            Dispose();
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            if (nome.Text == "")
            {
                MessageBox.Show("O campo nome não pode estar Vazio, Erro Ao Salvar!");
                nome.Focus();
                return;
            }
            if (cpf.Text == "")
            {
                MessageBox.Show("O campo cpf não pode estar Vazio, Erro Ao Salvar!");
                cpf.Focus();
                return;
            }
            if (endereco.Text == "")
            {
                MessageBox.Show("O campo endereco não pode estar Vazio, Erro Ao Salvar!");
                endereco.Focus();
                return;
            }
            if (n.Text == "")
            {
                MessageBox.Show("O campo numero não pode estar Vazio, Erro Ao Salvar!");
                n.Focus();
                return;
            }
            if (telefone.Text == "")
            {
                MessageBox.Show("O campo telefone não pode estar Vazio, Erro Ao Salvar!");
                telefone.Focus();
                return;
            }
            if (email.Text == "")
            {
                MessageBox.Show("O campo email não pode estar Vazio, Erro Ao Salvar!");
                email.Focus();
                return;
            }
            else
            {
                conn.Open();

                comando.CommandText = "INSERT INTO cliente (nome,cpf,endereco,n,telefone,email) values ('" + nome.Text + "','" + cpf.Text + "','" + endereco.Text + "','" + n.Text + "','" + telefone.Text + "','" + email.Text + "')";
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

            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (codigo.Text != "")
            {
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
            }
            else
            {
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
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            //Excluir Cor
            String x = "";
            conn.Open();
            comando.CommandText = "select * FROM cliente where codigo='" + codigo.Text + "'";
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
                comando.CommandText = "DELETE FROM cliente where codigo='" + codigo.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cliente Excluido com Sucesso!");
            }
            else if (codigo.Text == "")
            {
                MessageBox.Show("Prencha o Dados do Campo Codigo!");
                codigo.Focus();

            }
            else
            {
                MessageBox.Show("Dados do Campo Codigo Invalidos!");
                codigo.Focus();
            }
        }

        private void consultarTiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsCliente frm = new ConsCliente();
            frm.Show();
            Visible = false;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            Dispose();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
   }