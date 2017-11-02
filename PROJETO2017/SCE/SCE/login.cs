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
    public partial class login : Form
    {

        //string de Conexão
        // conexao online azure
        SqlConnection conn = new SqlConnection("Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        

        public login()
        {
            InitializeComponent();
            this.Text = "Login SCE";
            nome.Select();   // iniciar com o foco no nome.
   
        }
        
        private void login_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // aqui ele reconhece que foi apertado o ENTER, isso sei que está funcionando
            {

                entrar_Click(sender, e);

            }
        }

        private void entrar_Click(object sender, EventArgs e){
            //validação de login
            String x = "";
            String y = "";
            conn.Open();
            comando.CommandText = "select * FROM usuario where nome='" + nome.Text + "'and senha='" + senha.Text + "'";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    x = dr[1].ToString();
                    y = dr[3].ToString();
                }

            }
            conn.Close();
            if (x != "" && y != "")
            {
                MessageBox.Show("Dados Informado Corretamente!");
                menu frm = new menu();
                frm.Show();
                Visible = false;
            }
            else if (nome.Text == "" && senha.Text == "")
            {
                MessageBox.Show("Informe Usuario e Senha!");
                nome.Text = String.Empty;
                senha.Text = String.Empty;
                nome.Focus();

            }
            else
            {
                MessageBox.Show("Dados do Cmapo Codigo Invalidos!");
                nome.Text = String.Empty;
                senha.Text = String.Empty;
                nome.Focus();
            }
        }

        private void cancelar_Click(object sender, EventArgs e){
            //botão cancelar limpa campos e volta o foco para nome 
            nome.Focus();
            nome.Text = String.Empty;
            senha.Text = String.Empty;
        }
    }
}
