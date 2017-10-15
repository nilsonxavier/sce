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
    public partial class conf : Form
    {
        //string de Conexão
        SqlConnection conn = new SqlConnection("Data Source=wisley-pc;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public conf()
        {
            InitializeComponent();
            
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "update conf set vaga ='" + vaga.Text + "'where codigo = 1";
            comando.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Salvo Com Sucesso!");
        }

        private void conf_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            String x = "";
            conn.Open();
            comando.CommandText = "select * FROM conf where codigo = 1";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    x = dr[1].ToString();
                    vaga.Text = x;
                }
                
            }
            conn.Close();
        }
    }
}
