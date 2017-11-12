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
    public partial class menu : Form
    {
        

        //string de Conexão
        // conexao online azure
        SqlConnection conn = new SqlConnection("Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public menu()
        {
            InitializeComponent();
            // COlocando nome no Titulo
            this.Text = "Sistema de Controle de Estacionameto  SCE";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            listaGrid2();
            listaGrid3();
            comando.Connection = conn;
        }

        private void tiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastrotipoveiculos = new cadastrotipoveiculos();
            cadastrotipoveiculos.ShowDialog();
            //cadastrotipoveiculos frm = new cadastrotipoveiculos();
           // frm.Show();
        }

        private void corDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastrocorveiculos = new cadastrocorveiculos();
            cadastrocorveiculos.ShowDialog();
            //cadastrocorveiculos frm = new cadastrocorveiculos();
            //frm.Show();
        }

        private void tamanhoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadtamanho = new cadtamanho();
            cadtamanho.ShowDialog();
            //cadtamanho frm = new cadtamanho();
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String x = "";
            String y = "";
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
                MessageBox.Show("Não Existe Caixa Aberto!");
            }
            else
            {
                var Registro = new Registro();
                Registro.ShowDialog();
                //Registro frm = new Registro();
                //frm.Show();
            }
            conn.Close();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadcliente = new cadcliente();
            cadcliente.ShowDialog();
            //cadcliente frm = new cadcliente();
            //frm.Show();
        }

        private void utilitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usuario = new usuario();
            usuario.ShowDialog();
            //usuario frm = new usuario();
            // frm.Show();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conf = new conf();
            conf.ShowDialog();
            //conf frm = new conf();
            //frm.Show();
        }

        private void tamanhoVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var cadtamanho = new cadtamanho();
            cadtamanho.ShowDialog();
            //cadtamanho frm = new cadtamanho();
            //frm.Show();
        }

        private void registroDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String x = "";
            String y = "";
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
                MessageBox.Show("Não Existe Caixa Aberto!");
                
            }
            else
            {
                var Registro = new Registro();
                Registro.ShowDialog();
                //Registro frm = new Registro();
                //frm.Show();
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var caixa = new caixa();
            caixa.ShowDialog();
            //caixa frm = new caixa();
            //frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String x = "";
            String y = "";
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
                MessageBox.Show("Não Existe Caixa Aberto!");
                }
            else
            {
                var Registro = new Registro();
                Registro.ShowDialog();
                //Registro frm = new Registro();
                //frm.Show();
            }
            conn.Close();


        }

        private void registroDeSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String x = "";
            String y = "";
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
                MessageBox.Show("Não Existe Caixa Aberto!");
                
            }
            else
            {
                var Registro = new Registro();
                Registro.ShowDialog();
                //Registro frm = new Registro();
                //frm.Show();
            }
            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            }
        private void listaGrid2()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select Codigo as 'Codigo', placa as 'Placa Veiculo',tpveiculos as 'Tipo de Veiculo',categoria as 'Categoria do Veiculo',cor as 'Cor do Veiculo',dataentrada as 'Data Entrada',horaentrada as 'Hora Entrada' from registro where valorpago is null";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgpendentes.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid3()
        {
            string x = "";
            x = DateTime.Now.ToString("dd/MM/yyyy");
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo',placa as 'Placa Veiculo',datasaida as 'Data Saida Veiculo',valorpago as 'Valor' from registro where datasaida='" + x + "'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgcaixa.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }

        private void dgpendentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgcaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaGrid3();
            listaGrid2();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var caixa = new caixa();
            caixa.ShowDialog();
            //caixa frm = new caixa();
           // frm.Show();
            
        }
    }
}
