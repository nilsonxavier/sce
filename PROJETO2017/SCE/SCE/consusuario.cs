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
    public partial class consusuario : Form
    {
        public consusuario()
        {
            InitializeComponent();
        }
        private void listaGrid()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select nome as 'Usuario',email as 'Email',endereco as 'Endereço Usuario',funcao as 'Função do Usuario' from usuario";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgusuario.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid2()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select nome as 'Usuario',email as 'Email',endereco as 'Endereço Usuario',funcao as 'Função do Usuario' from usuario where nome= '"+usuario.Text+"'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgusuario.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void listaGrid3()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select nome as 'Usuario',email as 'Email',endereco as 'Endereço Usuario',funcao as 'Função do Usuario' from usuario where email= '" + email.Text + "'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgusuario.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }

        private void consusuario_Load(object sender, EventArgs e)
        {
            
            listaGrid();
            usuario.Focus();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario frm = new usuario();
            frm.Show();
            Visible = false;
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                MessageBox.Show("Campo não pode estar em branco!");
                usuario.Focus();
            }
            else {
                listaGrid2();
            }
        }

        private void ok2_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                MessageBox.Show("Campo não pode estar em branco!");
                email.Focus();
            }
            else
            {
                listaGrid3();
            }
        }

    

    private void TODOS_Click(object sender, EventArgs e)
        {
            listaGrid();
        }
    }
}
