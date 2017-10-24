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
            comando.Connection = conn;
        }

        private void tiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrotipoveiculos frm = new cadastrotipoveiculos();
            frm.Show();
        }

        private void corDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrocorveiculos frm = new cadastrocorveiculos();
            frm.Show();
        }

        private void tamanhoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadtamanho frm = new cadtamanho();
            frm.Show();
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
                    y = dr[3].ToString();
                }
            }
            if (x != y) {
                MessageBox.Show("Não Existe Caixa Aberto!");
                caixa frm = new caixa();
                frm.Show();
            }
            else
            {
                Registro frm = new Registro();
                frm.Show();
            }
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcliente frm = new cadcliente();
            frm.Show();
        }

        private void utilitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario frm = new usuario();
            frm.Show();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conf frm = new conf();
            frm.Show();
        }

        private void tamanhoVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadtamanho frm = new cadtamanho();
            frm.Show();
        }

        private void registroDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caixa frm = new caixa();
            frm.Show();
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
                    y = dr[3].ToString();
                }
            }
            if (x != y)
            {
                MessageBox.Show("Não Existe Caixa Aberto!");
                caixa frm = new caixa();
                frm.Show();
            }
            else
            {
                Registro frm = new Registro();
                frm.Show();
            }
        }

        private void registroDeSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.Show();
        }
    }
}
