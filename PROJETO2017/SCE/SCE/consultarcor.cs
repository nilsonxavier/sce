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
    public partial class consultarcor : Form
    {
        public consultarcor()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var cadastrocorveiculos = new cadastrocorveiculos();
            cadastrocorveiculos.ShowDialog();
        }
        private void listaGrid()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo', cor as 'Cor' from tpcor";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgcor.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid2()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo', cor as 'Cor' from tpcor where cor='"+cor.Text+"'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgcor.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }

        private void consultarcor_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cor.Text == "")
            {
                MessageBox.Show("Preencha o Campo!");
                cor.Focus();
            }
            else
            {
                listaGrid2();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
