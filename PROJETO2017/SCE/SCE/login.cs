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
        SqlConnection conn = new SqlConnection("Data Source=WISLEY-PC;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        

        public login()
        {
            InitializeComponent();
        }
        
        private void login_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
        }

        private void entrar_Click(object sender, EventArgs e){
            //validação local
            if (nome.Text == "wisley" && senha.Text == "wisley"){
                MessageBox.Show("Dado Informado Corretamente!");
                menu frm = new menu();
                frm.Show();
                Visible = false;
            }else if (nome.Text == "" && senha.Text == ""){
                MessageBox.Show("Informe Usuario e Senha!");
                nome.Focus();

            }else {
                MessageBox.Show("Usuario ou senha Invalidos!");
                nome.Focus();
            }
            //validação de login via banco de dados
            /*
            if (nome.Text == "" && senha.Text == ""){
                MessageBox.Show("Informe Usuario e Senha!");
                nome.Focus();
            }
            else{
                conn.Open();
                comando.CommandText = "select * FROM usuario where nome='" + nome.Text + "'and senha='" + senha.Text + "'";
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Dado Informado Corretamente!");
                menu frm = new menu();
                frm.Show();
                Visible = false;
                conn.Close();
                
            }*/
        }

        private void cancelar_Click(object sender, EventArgs e){
            //botão cancelar limpa campos e volta o foco para nome 
            nome.Focus();
            nome.Text = String.Empty;
            senha.Text = String.Empty;
        }
    }
}
