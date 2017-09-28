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
    public partial class usuario : Form
    {
        //string de Conexão
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KA74H0G;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
       

        public usuario()
        {
            InitializeComponent();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            codigo.Text = String.Empty;
            nome.Text = String.Empty;
            email.Text = String.Empty;
            endereco.Text = String.Empty;
            senha.Text = String.Empty;
            csenha.Text = String.Empty;
            nome.Enabled = true;
            email.Enabled = true;
            endereco.Enabled = true;
            senha.Enabled = true;
            csenha.Enabled = true;
            funcao1.Enabled = true;
            novo.Enabled = false;
            gravar.Enabled = true;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            codigo.Enabled = false;
            nome.Focus();
        }

        private void funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gravar_Click(object sender, EventArgs e)
        {
            if (nome.Text == "")
            {
                MessageBox.Show("O campo nome não pode estar Vazio, Erro Ao Salvar!");
                nome.Focus();
                return;
            } if (funcao1.Text == "")
            {
                MessageBox.Show("O campo função não pode estar Vazio, Erro Ao Salvar!");
                funcao1.Focus();
                return;
            }
            if (email.Text == "")
            {
                MessageBox.Show("O campo email não pode estar Vazio, Erro Ao Salvar!");
                email.Focus();
                return;
            }
            if (endereco.Text == "")
            {
                MessageBox.Show("O campo endereço não pode estar Vazio, Erro Ao Salvar!");
                endereco.Focus();
                return;
            }
            if (senha.Text == "")
            {
                MessageBox.Show("O campo senha não pode estar Vazio, Erro Ao Salvar!");
                senha.Focus();
                return;
            }
            if (csenha.Text == "")
            {
                MessageBox.Show("O campo confirmar senha não pode estar Vazio, Erro Ao Salvar!");
               csenha.Focus();
                return;
            }
            if (senha.Text != csenha.Text)
            {
                MessageBox.Show("O campo senha diferente do campo confirmar senha informe corretamente os campos citados,Erro ao Salvar!");
                csenha.Focus();
                return;
            }
            else
            {


                conn.Open();
                comando.CommandText = "INSERT INTO usuario (nome,email,senha,endereco,funcao) values ('" + nome.Text + "','" + email.Text + "','" + senha.Text + "','" + endereco.Text + "','" + funcao1.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                codigo.Text = String.Empty;
                codigo.Enabled = true;
                nome.Text = String.Empty;
                nome.Enabled = false;
                funcao1.Text = String.Empty;
                funcao1.Enabled = false;
                email.Text = String.Empty;
                email.Enabled = false;
                endereco.Text = String.Empty;
                endereco.Enabled = false;
                senha.Text = String.Empty;
                senha.Enabled = false;
                csenha.Enabled = false;
                csenha.Text = String.Empty;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (codigo.Text != "")
            {
                codigo.Focus();
                codigo.Enabled = true;
                novo.Enabled = true;
                gravar.Enabled = false;
                excluir.Enabled = true;
                cancelar.Enabled = false;
                codigo.Focus();
                codigo.Text = String.Empty;
                nome.Enabled = false;
                nome.Text = String.Empty;
                funcao1.Text = String.Empty;
                funcao1.Enabled = false;
                email.Text = String.Empty;
                email.Enabled = false;
                endereco.Text = String.Empty;
                endereco.Enabled = false;
                senha.Text = String.Empty;
                senha.Enabled = false;
                csenha.Enabled = false;
                csenha.Text = String.Empty;

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
                codigo.Text = String.Empty;
                nome.Enabled = false;
                nome.Text = String.Empty;
                funcao1.Text = String.Empty;
                funcao1.Enabled = false;
                email.Text = String.Empty;
                email.Enabled = false;
                endereco.Text = String.Empty;
                endereco.Enabled = false;
                senha.Text = String.Empty;
                senha.Enabled = false;
                csenha.Enabled = false;
                csenha.Text = String.Empty;
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            codigo.Enabled = true;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            codigo.Text = String.Empty;
            nome.Enabled = false;
            nome.Text = String.Empty;
            funcao1.Text = String.Empty;
            funcao1.Enabled = false;
            email.Text = String.Empty;
            email.Enabled = false;
            endereco.Text = String.Empty;
            endereco.Enabled = false;
            senha.Text = String.Empty;
            senha.Enabled = false;
            csenha.Enabled = false;
            csenha.Text = String.Empty;
        }

        private void consultarTiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
