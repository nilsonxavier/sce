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
    public partial class constamanho : Form
    {
        public constamanho()
        {
            InitializeComponent();
        }
        private void listaGrid()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo', modelo as 'Modelo' from categoria";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgtamanho.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid2()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo', modelo as 'Modelo' from categoria where modelo='" + cor.Text + "'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgtamanho.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }


        private void constamanho_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var cadtamanho = new cadtamanho();
            cadtamanho.ShowDialog();

          //  cadtamanho frm = new cadtamanho();
           // frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaGrid2();
        }
    }
}
