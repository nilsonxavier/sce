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
    public partial class caixa : Form
    {
        //string de Conexão

        SqlConnection conn = new SqlConnection("Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public caixa()
        {
            InitializeComponent();
            listaGrid2();
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            cod.Enabled = true;
            cod.Text = String.Empty;
            nome.Enabled = false;
            nome.Text = String.Empty;
            datacaixa.Enabled = false;
            datacaixa.Text = String.Empty;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            listaGrid();
            listaGrid2();
        }
        private void listaGrid()
        {
            
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo',nome as 'Funcionario',datacaixa as 'Abertura Caixa',datafcaixa as 'Fechamento Caixa' from caixa";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                abcaixa.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid2()
        {
            string x = "";
            x = DateTime.Now.ToString("dd/MM/yyyy");
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo',placa as 'Placa Veiculo',datasaida as 'Data Saida Veiculo',valorpago as 'Valor' from registro where datasaida='" +x+ "'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                movcaixa.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            string x = "";
            string y = "";
            x = DateTime.Now.ToString("dd/MM/yyyy");
            conn.Open();
            comando.CommandText = "select * FROM caixa where datacaixa='" + x + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    y = dr[2].ToString();

                }
            }
            if (x != y)
            {
                cod.Enabled = false;
                cod.Text = String.Empty;
                nome.Enabled = true;
                nome.Text = String.Empty;
                datacaixa.Text = DateTime.Now.ToString("dd/MM/yyyy");
                novo.Enabled = false;
                gravar.Enabled = true;
                cancelar.Enabled = true;
                excluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Caixa Aberto!");
            }
            conn.Close();
            
        }

        private void gravar_Click(object sender, EventArgs e)
        {
           
            if (nome.Text == "")
            {
                MessageBox.Show("O campo Nome do Funcionario não pode estar Vazio, Erro Ao Salvar!");
                nome.Focus();
                return;
            }     
            else
            {
                conn.Open();

                comando.CommandText = "INSERT INTO caixa (nome,datacaixa) values ('" + nome.Text + "','" + datacaixa.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                cod.Enabled = true;
                cod.Text = String.Empty;
                nome.Enabled = false;
                nome.Text = String.Empty;
                datacaixa.Enabled = false;
                datacaixa.Text = String.Empty;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
                listaGrid();

            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            cod.Enabled = true;
            cod.Text = String.Empty;
            nome.Enabled = false;
            nome.Text = String.Empty;
            datacaixa.Enabled = false;
            datacaixa.Text = String.Empty;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            listaGrid();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            //Excluir tipo de veiculos
            String x = "";
            conn.Open();
            comando.CommandText = "select * FROM caixa where codigo='" + cod.Text + "'";
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
                comando.CommandText = "DELETE FROM caixa where codigo='" + cod.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tipo de Veiculo Excluido com Sucesso!");

                cod.Text = String.Empty;
                cod.Focus();
                listaGrid();
            }
            else if (cod.Text == "")
            {
                MessageBox.Show("Prencha o Dados do Campo Codigo!");
                cod.Focus();

            }
            else
            {
                MessageBox.Show("Dados do Cmapo Codigo Invalidos!");
                cod.Focus();
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datacaixa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
