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
    public partial class consultipoveic : Form
    {
        public consultipoveic()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastrotipoveiculos = new cadastrotipoveiculos();
            cadastrotipoveiculos.ShowDialog();
            //cadastrotipoveiculos frm = new cadastrotipoveiculos();
            //frm.Show();
            Visible = false;
        }

        private void listaGrid()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo', tipo as 'Tipo de Veiculos' from tpveiculos";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgtipo.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid2()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select codigo as 'Codigo', tipo as 'Tipo de Veiculos' from tpveiculos where tipo='"+ nome .Text+ "'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgtipo.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }

        private void consultipoveic_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void TODOS_Click(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            if (nome.Text == "")
            {
                MessageBox.Show("Preencha o Campo!");
                nome.Focus();
            }
            else
            {
                listaGrid2();
            }
            
        }
    }
}
