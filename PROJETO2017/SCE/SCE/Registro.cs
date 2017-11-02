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
            string strsql = "select Codigo as 'Codigo', placa as 'Placa Veiculo',tpveiculos as 'Tipo de Veiculo',categoria as 'Categoria do Veiculo',cor as 'Cor do Veiculo',dataentrada as 'Data Entrada',horaentrada as 'Hora Entrada',datasaida as 'Data Saida',horasaida as 'Hora Saida',valor as 'Valor do Estacionamento',valorpago as 'Valor Faturado' from registro";
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
            datasaida.Enabled = false;
            datasaida.Text = String.Empty;
            horasaida.Enabled = false;
            horasaida.Text = String.Empty;
            total.Enabled = false;
            total.Text = String.Empty;
            valorpago.Enabled = false;
            valorpago.Text = String.Empty;

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
            datasaida.Enabled = false;
            horasaida.Text = String.Empty;
            datasaida.Enabled = false;
            horasaida.Text = String.Empty;
            total.Enabled = false;
            total.Text = String.Empty;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            datasaida.Enabled = false;
            datasaida.Text = String.Empty;
            horasaida.Enabled = false;
            horasaida.Text = String.Empty;
            total.Enabled = false;
            total.Text = String.Empty;
            valorpago.Enabled = false;
            valorpago.Text = String.Empty;
            saida.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechar_Click(object sender, EventArgs e)
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
            datasaida.Enabled = false;
            horasaida.Text = String.Empty;
            datasaida.Enabled = false;
            horasaida.Text = String.Empty;
            total.Enabled = false;
            total.Text = String.Empty;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            datasaida.Enabled = false;
            datasaida.Text = String.Empty;
            horasaida.Enabled = false;
            horasaida.Text = String.Empty;
            total.Enabled = false;
            total.Text = String.Empty;
            valorpago.Enabled = false;
            valorpago.Text = String.Empty;
            Dispose();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            //Excluir tipo de veiculos
            String x = "";
            String y = "";
            conn.Open();
            comando.CommandText = "select * FROM registro where codigo='" + cod.Text + "'";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    x = dr[0].ToString();
                    y = dr[10].ToString();
                }

            }
            conn.Close();
            if (x != "" && y == "")
            {
                conn.Open();
                comando.CommandText = "DELETE FROM registro where codigo='" + cod.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro de Veiculo Excluido com Sucesso!");
                cod.Text = String.Empty;
                cod.Focus();
                listaGrid();
            }
            else if (cod.Text == "")
            {
                MessageBox.Show("Prencha o Dados do Campo Codigo!");
                cod.Focus();

            }
            else
            {
                MessageBox.Show("Dados do Movimento ja faturado!");
                cod.Focus();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cod.Text == "") {

                MessageBox.Show("Informe o Codigo da Entrada!");
            }
            else
            {
                string x = "";
                string y = "";
                string z = "";
                string h = "";
                string a = "";
                string v = "";
                string t = "";
                string q = "";
                conn.Open();
                //puxando dados tipo de veiculos
                comando.CommandText = "select * from registro where codigo='" + cod.Text + "'";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        x = dr[1].ToString();
                        placaCarro.Text = x;
                        y = dr[2].ToString();
                        comboBox2.Text = y;
                        z = dr[3].ToString();
                        comboBox4.Text = z;
                        h = dr[4].ToString();
                        comboBox3.Text = h;
                        t = dr[5].ToString();
                        dataEntrada.Text = t;
                        q = dr[6].ToString();
                        horaentrada.Text = q;

                        cod.Enabled = false;
                        placaCarro.Enabled = false;
                        comboBox2.Enabled = false;
                        comboBox4.Enabled = false;
                        comboBox3.Enabled = false;
                        dataEntrada.Enabled = false;
                        horaentrada.Enabled = false;
                        datasaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        horasaida.Text = DateTime.Now.ToString("HH:mm:ss");
                        var xtrsaida = Convert.ToDateTime(horasaida.Text);
                        var xtrentrada = Convert.ToDateTime(horaentrada.Text);
                        datasaida.Enabled = false;
                        horasaida.Enabled = false;
                        total.Enabled = true;
                        valorpago.Enabled = true;
                        cancelar.Enabled = true;
                        novo.Enabled = false;
                        excluir.Enabled = false;
                        fatura.Enabled = true;
                        saida.Enabled = false;
                        // calculando as horas
                        var dtsaida = xtrsaida.Subtract(xtrentrada).TotalHours;
                        // Convertendo a exibição dos calculos das horas
                        Double dtsaida2 = Convert.ToDouble(dtsaida);
                        tt.Text = String.Format("{0:n}", dtsaida2);
                        //calculando os valores
                        Double valor_estacionamento = 5.50;
                        Double total_hora = Convert.ToDouble(tt.Text);
                        // Convertendo a exibição dos valores
                        Double total2 = total_hora * valor_estacionamento;
                        total.Text = Convert.ToString(total2);
                        total.Text = String.Format("{0:n}", total2);
                    }

                }
                conn.Close();


            }
        }

        private void valorpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (total.Text == "")
            {

                MessageBox.Show("Informe o Total do Estacionamento!");
            }
            else if (valorpago.Text == "")
            {

                MessageBox.Show("Informe o Valor de Faturamento!");
            }
            
            else
            {
                string x = "";
                string y = "";
                string z = "";
                x = DateTime.Now.ToString("dd/MM/yyyy");
                conn.Open();
                //puxando dados tipo de veiculos
                comando.CommandText = "select * from caixa where datacaixa='" + x + "'";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        y = dr[0].ToString();

                        z = dr[2].ToString();
                    }
                }
                conn.Close();
                conn.Open();
                comando.CommandText = "update registro set datasaida ='" + datasaida.Text + "'where codigo = '" + cod.Text + "'";
                comando.ExecuteNonQuery();

                comando.CommandText = "update registro set horasaida ='" + horasaida.Text + "'where codigo = '" + cod.Text + "'";
                comando.ExecuteNonQuery();

                comando.CommandText = "update registro set valor ='" + total.Text + "'where codigo = '" + cod.Text + "'";
                comando.ExecuteNonQuery();

                comando.CommandText = "update registro set valorpago ='" + valorpago.Text + "'where codigo = '" + cod.Text + "'";
                comando.ExecuteNonQuery();

                comando.CommandText = "update registro set datacaixa ='" + z + "'where codigo = '" + cod.Text + "'";
                comando.ExecuteNonQuery();

                comando.CommandText = "update registro set codigocaixa ='" + y + "'where codigo = '" + cod.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pago Com Sucesso!");

                listaGrid();
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
                datasaida.Enabled = false;
                horasaida.Text = String.Empty;
                datasaida.Enabled = false;
                horasaida.Text = String.Empty;
                total.Enabled = false;
                total.Text = String.Empty;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
                datasaida.Enabled = false;
                datasaida.Text = String.Empty;
                horasaida.Enabled = false;
                horasaida.Text = String.Empty;
                total.Enabled = false;
                total.Text = String.Empty;
                valorpago.Enabled = false;
                valorpago.Text = String.Empty;

            }

       }

            private void horasaida_TextChanged(object sender, EventArgs e)
            {

            }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }
    }
    } 
