﻿using System;
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
    public partial class cadtamanho : Form
    {
        //string de Conexão
        SqlConnection conn = new SqlConnection("Data Source=azuresgbd.database.windows.net;Initial Catalog=SGBD;Persist Security Info=True;User ID=nilsonxavier;Password=Nilson33213264");
        //SqlConnection conn = new SqlConnection("Data Source=wisley-pc;Initial Catalog=SGBD;Persist Security Info=True;User ID=sa;Password=123;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public cadtamanho()
        {
            InitializeComponent();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            //Excluir tamanho
            String x = "";
            conn.Open();
            comando.CommandText = "select * FROM categoria where codigo='" + codigo.Text + "'";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    x = dr[0].ToString();
                }

            }
            conn.Close();
            if (x != "")
            {
                conn.Open();
                comando.CommandText = "DELETE FROM categoria where codigo='" + codigo.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tipo de Tamanho de Veiculos Excluido com Sucesso!");
            }
            else if (codigo.Text == "")
            {
                MessageBox.Show("Prencha o Dados do Campo Codigo!");
                codigo.Focus();

            }
            else
            {
                MessageBox.Show("Dados do Campo Codigo Invalidos!");
                codigo.Focus();
            }
        }

        private void novo_Click(object sender, EventArgs e)
        {
            codigo.Text = String.Empty;
            cor.Text = String.Empty;
            cor.Enabled = true;
            novo.Enabled = false;
            gravar.Enabled = true;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            codigo.Enabled = false;
            cor.Focus();
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            if (cor.Text == "")
            {
                MessageBox.Show("O campo Tamanho não pode estar Vazio, Erro Ao Salvar!");
                cor.Focus();
                return;
            }
            else
            {
                conn.Open();

                comando.CommandText = "INSERT INTO categoria (modelo) values ('" + cor.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salvo Com Sucesso!");
                codigo.Text = String.Empty;
                cor.Text = String.Empty;
                codigo.Enabled = true;
                cor.Enabled = false;
                novo.Enabled = true;
                gravar.Enabled = false;
                cancelar.Enabled = false;
                excluir.Enabled = true;
                conn.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (codigo.Text != "")
            {
                Enabled = true;
            cancelar.Enabled = false;
            codigo.Focus();
            cor.Enabled = false;
            codigo.Text = String.Empty;
            cor.Text = String.Empty;
            }
            else
            {
                codigo.Focus();
                codigo.Enabled = true;
                novo.Enabled = true;
                gravar.Enabled = false;
                excluir.Enabled = true;
                cancelar.Enabled = false;
                codigo.Focus();
                cor.Enabled = false;
                codigo.Text = String.Empty;
                cor.Text = String.Empty;
            }
}

        private void fechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cadtamanho_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            codigo.Text = String.Empty;
            cor.Text = String.Empty;
            codigo.Enabled = true;
            cor.Enabled = false;
            novo.Enabled = true;
            gravar.Enabled = false;
            cancelar.Enabled = false;
            excluir.Enabled = true;
            codigo.Focus();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarTiposDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var constamanho = new constamanho();
            constamanho.ShowDialog();
            //constamanho frm = new constamanho();
            //frm.Show();
            
        }
    }
}
