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


            int W = 140;
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
            Point ponto6 = new Point(120, W);
            Point ponto7 = new Point(200, W);
            Point ponto8 = new Point(320, W);
            Point ponto9 = new Point(605, W);

            String x = "";
            String y = "";
            String h = "";
            String hh = "";

            


            conn.Open();
            //puxando dados tipo de veiculos
            comando.CommandText = "select codigo,placa,datasaida,valorpago from registro where datasaida = '" + datacaixa.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    x = dr[0].ToString();
                    y = dr[1].ToString();
                    h = dr[2].ToString();
                    hh = dr[3].ToString();
                }
            }
            conn.Close();

            //implementando no Relatorio
            e.Graphics.DrawString(Cabecalho, letra, cor, ponto);
            e.Graphics.DrawString(Linha, letra, cor, ponto1);
            e.Graphics.DrawString(DataRelatorio, letra, cor, ponto2);
            e.Graphics.DrawString(x, letra, cor, ponto4);
            e.Graphics.DrawString(y, letra, cor, ponto5);
            e.Graphics.DrawString(opcao, letra, cor, ponto6);
            e.Graphics.DrawString(opcao2, letra, cor, ponto7);
            e.Graphics.DrawString(opcao3, letra, cor, ponto8);
            e.Graphics.DrawString(opcao5, letra, cor, ponto9);
            //e.Graphics.DrawString(opcao5, letra, cor, ponto10);
            for (int v = 0; v <= 10; v++)
            {
                //dados
                e.Graphics.DrawString(x, letra, cor1, ponto4);
                e.Graphics.DrawString(y, letra, cor1, ponto5);
                e.Graphics.DrawString(h, letra, cor1, ponto11);
                e.Graphics.DrawString(hh, letra, cor1, ponto12);
                W = W + 40;
            }


        }

        private void grelatorio_Click(object sender, EventArgs e)
        {
            prtdoc.Print();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

            comando.Connection = conn;
        }

        private void prtdoc_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            
        }
    }
}
