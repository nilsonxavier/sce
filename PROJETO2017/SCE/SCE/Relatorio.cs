using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace SCE
{
    public partial class Relatorio : Form
    {
        //string de Conexão

        SqlConnection conn = new SqlConnection("Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public Relatorio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void prtdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            String Cabecalho = "Relatorio De Fluxo de Caixa";
            String Linha = "__________________________________________________________________";
            String opcao = "Codigo";
            String opcao2 = "Placa Veiculo";
            String opcao3 = "Data Saida";
            //String opcao4 = "Veiculo";
            String opcao5 = "Valor";
            String DataRelatorio = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            Font letra = new Font("Ariel", 17, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Blue);
            SolidBrush cor1 = new SolidBrush(Color.Black);


            
            //cabeçalho
            Point ponto = new Point(100, 100);
            Point ponto1 = new Point(100, 110);
            Point ponto2 = new Point(605, 100);
            //Dados da tabela
            Point ponto4 = new Point(120, 160);
            Point ponto5 = new Point(200, 160);
            Point ponto11 = new Point(320, 160);
            Point ponto12 = new Point(605, 160);
            // opção de menus
            Point ponto6 = new Point(120, 140);
            Point ponto7 = new Point(200, 140);
            Point ponto8 = new Point(320, 140);
            Point ponto9 = new Point(605, 140);
            String k = "";
            conn.Open();
            //puxando dados tipo de veiculos
            comando.CommandText = "select count(*) from registro where datasaida = '" + datacaixa.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    k = dr[0].ToString();

                }
            }
            int kk = Convert.ToInt16(k);
            conn.Close();

            //String x = "";
            //String y = "";
            //String h = "";
            //String hh = "";
            
            String[] x = new string[kk];
            String[] y = new string[kk];
            String[] h = new string[kk];
            String[] hh = new string[kk];
            conn.Open();
            //puxando dados tipo de veiculos
            comando.CommandText = "select codigo,placa,datasaida,valorpago from registro where datasaida = '" + datacaixa.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    for (int z = 0; z <= kk; z++) { 
                    x[z] = dr[0].ToString();
                    y[z] = dr[1].ToString();
                    h[z] = dr[2].ToString();
                    hh[z] = dr[3].ToString();
                    }
                }
            }

            conn.Close();
            //implementando no Relatorio
            e.Graphics.DrawString(Cabecalho, letra, cor, ponto);
            e.Graphics.DrawString(Linha, letra, cor, ponto1);
            e.Graphics.DrawString(DataRelatorio, letra, cor, ponto2);
            e.Graphics.DrawString(opcao, letra, cor, ponto6);
            e.Graphics.DrawString(opcao2, letra, cor, ponto7);
            e.Graphics.DrawString(opcao3, letra, cor, ponto8);
            e.Graphics.DrawString(opcao5, letra, cor, ponto9);
            //e.Graphics.DrawString(opcao5, letra, cor, ponto10);
            int aqs = 0;
            int W = 160;
            while(aqs < kk)
            {
                for (int z = 0; z <= kk; z++)
                {
                    e.Graphics.DrawString(x[z], letra, cor1, new Point(120, W));
                    e.Graphics.DrawString(y[z], letra, cor1, new Point(200, W));
                    e.Graphics.DrawString(h[z], letra, cor1, new Point(320, W));
                    e.Graphics.DrawString(hh[z], letra, cor1, new Point(605, W));
                    e.Graphics.DrawString(Linha, letra, cor, new Point(100, W));
                    W += 20;
                    aqs++;
                    
                }
            }

            
        }

        private void grelatorio_Click(object sender, EventArgs e)
        {
           pre.Document = prtdoc;
            
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

            comando.Connection = conn;
        }

        private void prtdoc_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prtdoc.Print();
        }
    }
}
