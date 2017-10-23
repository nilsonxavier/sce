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

    public partial class Registro : Form
    {

        //string de Conexão
        
        SqlConnection conn = new SqlConnection("Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;



        public Registro()
        {
            InitializeComponent();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void gravar_Click(object sender, EventArgs e)
        {

            String x = "";
            String y = "";
            String z = "";
            if (placaCarro.Text == "")
            {
                MessageBox.Show("O campo Placa não pode estar Vazio, Erro Ao Salvar!");
                placaCarro.Focus();
                return;
            }
            else if (x != "")
            {
                MessageBox.Show("O campo Tipo de Veiculos diferente do cadastrado, Erro Ao Salvar!");
                comboBox2.Focus();
                return;
            }
            else if (y != "")
            {
                MessageBox.Show("O campo Categoria diferente do cadastrado, Erro Ao Salvar!");
                comboBox4.Focus();
                return;
            }
            else if (z != "")
            {
                MessageBox.Show("O campo cor diferente do cadastrado, Erro Ao Salvar!");
                comboBox3.Focus();
                return;
            }
            else if (dataEntrada.Text == "")
            {
                MessageBox.Show("O campo Data não pode estar Vazio, Erro Ao Salvar!");
                dataEntrada.Focus();
                return;
            }
            else if (horaentrada.Text == "")
            {
                MessageBox.Show("O campo Hora não pode estar Vazio, Erro Ao Salvar!");
                horaentrada.Focus();
                return;
            }
            else
            {
                conn.Open();

                comando.CommandText = "INSERT INTO registro (placa,tpveiculos,categoria,cor,dataentrada,horaentrada) values ('" + placaCarro.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + comboBox3.Text + "','" + dataEntrada.Text + "','" + horaentrada.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                cod.Enabled = true;
                cod.Text = String.Empty;
                placaCarro.Enabled = false;
                placaCarro.Text = String.Empty;
                comboBox2.Enabled = false;
                comboBox2.Text = String.Empty;
                comboBox4.Enabled = false;
                comboBox4.Text = String.Empty;
                comboBox3.Enabled = false;
                comboBox3.Text = String.Empty;
                dataEntrada.Enabled = false;
                dataEntrada.Text = String.Empty;
                horaentrada.Enabled = false;
                horaentrada.Text = String.Empty;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
                listaGrid();

            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaGrid()
        {
            string _strconn = @"Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264";
            string strsql = "select * from registro";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgregistro.DataSource = drlista;
            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
    private void novo_Click(object sender, EventArgs e)
    {


        cod.Enabled = false;
        cod.Text = String.Empty;
        placaCarro.Enabled = true;
        placaCarro.Text = String.Empty;
        comboBox2.Enabled = true;
        comboBox2.Text = String.Empty;
        comboBox4.Enabled = true;
        comboBox4.Text = String.Empty;
        comboBox3.Enabled = true;
        comboBox3.Text = String.Empty;
        dataEntrada.Enabled = false;
        horaentrada.Enabled = false;
        novo.Enabled = false;
        gravar.Enabled = true;
        cancelar.Enabled = true;
        excluir.Enabled = false;
        dataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
        horaentrada.Text = DateTime.Now.ToString("HH:mm:ss");
            conn.Open();
            //puxando dados tipo de veiculos
            comando.CommandText = "select codigo,tipo from tpveiculos";
            dr = comando.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            DataRow row = table.NewRow();
            row["tipo"] = "";
            table.Rows.InsertAt(row, 0);
            this.comboBox2.DataSource = table;
            this.comboBox2.ValueMember = "tipo";
            //puxando dados categoria
            comando.CommandText = "select codigo,modelo from categoria";
            dr = comando.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(dr);
            DataRow row2 = table2.NewRow();
            row2["modelo"] = "";
            table2.Rows.InsertAt(row2, 0);
            this.comboBox4.DataSource = table2;
            this.comboBox4.ValueMember = "modelo";
            //puxando dados de cor
            comando.CommandText = "select codigo,cor from tpcor";
            dr = comando.ExecuteReader();
            DataTable table3 = new DataTable();
            table3.Load(dr);
            DataRow row3 = table3.NewRow();
            row3["cor"] = "";
            table3.Rows.InsertAt(row3, 0);
            this.comboBox3.DataSource = table3;
            this.comboBox3.ValueMember = "cor";
            conn.Close();
       

    } 






        private void cancelar_Click(object sender, EventArgs e)
        {
            cod.Enabled = true;
            cod.Text = String.Empty;
            placaCarro.Enabled = false;
            placaCarro.Text = String.Empty;
            comboBox2.Enabled = false;
            comboBox2.Text = String.Empty;
            comboBox4.Enabled = false;
            comboBox4.Text = String.Empty;
            comboBox3.Enabled = false;
            comboBox3.Text = String.Empty;
            dataEntrada.Enabled = false;
            dataEntrada.Text = String.Empty;
            horaentrada.Enabled = false;
            horaentrada.Text = String.Empty;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechar_Click(object sender, EventArgs e)
        {

        }

        private void excluir_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgregistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
