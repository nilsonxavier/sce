using System;

namespace SCE
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placaCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataEntrada = new System.Windows.Forms.TextBox();
            this.horaentrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.fatura = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.saida = new System.Windows.Forms.Button();
            this.valorpago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.horasaida = new System.Windows.Forms.TextBox();
            this.datasaida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.dgregistro = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.kkk = new System.Windows.Forms.Label();
            this.busccodigo = new System.Windows.Forms.Button();
            this.pcodigo = new System.Windows.Forms.TextBox();
            this.pplaca = new System.Windows.Forms.TextBox();
            this.buscplaca = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.busctipo = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.Aberto = new System.Windows.Forms.Button();
            this.fechado = new System.Windows.Forms.Button();
            this.todos = new System.Windows.Forms.Button();
            this.ptipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(89, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(89, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(89, 118);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // placaCarro
            // 
            this.placaCarro.Location = new System.Drawing.Point(89, 65);
            this.placaCarro.Name = "placaCarro";
            this.placaCarro.Size = new System.Drawing.Size(100, 20);
            this.placaCarro.TabIndex = 15;
            this.placaCarro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Veiculo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Entrada";
            // 
            // dataEntrada
            // 
            this.dataEntrada.Location = new System.Drawing.Point(89, 171);
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(82, 20);
            this.dataEntrada.TabIndex = 19;
            // 
            // horaentrada
            // 
            this.horaentrada.Location = new System.Drawing.Point(254, 171);
            this.horaentrada.Name = "horaentrada";
            this.horaentrada.Size = new System.Drawing.Size(83, 20);
            this.horaentrada.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora Entrada";
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(89, 39);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(68, 20);
            this.cod.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(367, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(473, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Controle De Veiculos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.tt);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.fatura);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.saida);
            this.panel1.Controls.Add(this.valorpago);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.horasaida);
            this.panel1.Controls.Add(this.datasaida);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cod);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.horaentrada);
            this.panel1.Controls.Add(this.placaCarro);
            this.panel1.Controls.Add(this.dataEntrada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 205);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Location = new System.Drawing.Point(552, 72);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(0, 13);
            this.tt.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(485, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Total  hora:";
            // 
            // fatura
            // 
            this.fatura.Location = new System.Drawing.Point(484, 92);
            this.fatura.Name = "fatura";
            this.fatura.Size = new System.Drawing.Size(65, 23);
            this.fatura.TabIndex = 27;
            this.fatura.Text = "Faturar";
            this.fatura.UseVisualStyleBackColor = true;
            this.fatura.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Valor Pago";
            // 
            // saida
            // 
            this.saida.Location = new System.Drawing.Point(166, 37);
            this.saida.Name = "saida";
            this.saida.Size = new System.Drawing.Size(106, 23);
            this.saida.TabIndex = 26;
            this.saida.Text = "Saida De Veiculos";
            this.saida.UseVisualStyleBackColor = true;
            this.saida.Click += new System.EventHandler(this.button1_Click);
            // 
            // valorpago
            // 
            this.valorpago.Location = new System.Drawing.Point(378, 124);
            this.valorpago.Name = "valorpago";
            this.valorpago.Size = new System.Drawing.Size(100, 20);
            this.valorpago.TabIndex = 30;
            this.valorpago.TextChanged += new System.EventHandler(this.valorpago_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Dados De Entrada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Valor";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(378, 94);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 24;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Dados De Saida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hora Saida";
            // 
            // horasaida
            // 
            this.horasaida.Location = new System.Drawing.Point(379, 68);
            this.horasaida.Name = "horasaida";
            this.horasaida.Size = new System.Drawing.Size(100, 20);
            this.horasaida.TabIndex = 24;
            this.horasaida.TextChanged += new System.EventHandler(this.horasaida_TextChanged);
            // 
            // datasaida
            // 
            this.datasaida.Location = new System.Drawing.Point(379, 42);
            this.datasaida.Name = "datasaida";
            this.datasaida.Size = new System.Drawing.Size(100, 20);
            this.datasaida.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Data de Saida";
            // 
            // fechar
            // 
            this.fechar.Image = global::SCE.Properties.Resources.saida;
            this.fechar.Location = new System.Drawing.Point(232, 40);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(45, 43);
            this.fechar.TabIndex = 24;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // excluir
            // 
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Image = global::SCE.Properties.Resources.Excluir;
            this.excluir.Location = new System.Drawing.Point(181, 40);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(45, 43);
            this.excluir.TabIndex = 23;
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cancelar
            // 
            this.cancelar.Image = global::SCE.Properties.Resources.cancelar;
            this.cancelar.Location = new System.Drawing.Point(130, 41);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(45, 42);
            this.cancelar.TabIndex = 22;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // gravar
            // 
            this.gravar.Image = global::SCE.Properties.Resources.salvar;
            this.gravar.Location = new System.Drawing.Point(79, 41);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(45, 43);
            this.gravar.TabIndex = 21;
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // novo
            // 
            this.novo.Image = global::SCE.Properties.Resources.botão;
            this.novo.Location = new System.Drawing.Point(28, 41);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(45, 43);
            this.novo.TabIndex = 20;
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // dgregistro
            // 
            this.dgregistro.AllowUserToAddRows = false;
            this.dgregistro.AllowUserToDeleteRows = false;
            this.dgregistro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgregistro.Location = new System.Drawing.Point(9, 408);
            this.dgregistro.Name = "dgregistro";
            this.dgregistro.ReadOnly = true;
            this.dgregistro.Size = new System.Drawing.Size(1165, 228);
            this.dgregistro.TabIndex = 25;
            this.dgregistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgregistro_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1010, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Pesquisa_________________________________________________________________________" +
    "_______________________________________________________________";
            // 
            // kkk
            // 
            this.kkk.AutoSize = true;
            this.kkk.Location = new System.Drawing.Point(12, 330);
            this.kkk.Name = "kkk";
            this.kkk.Size = new System.Drawing.Size(43, 13);
            this.kkk.TabIndex = 27;
            this.kkk.Text = "Codigo:";
            // 
            // busccodigo
            // 
            this.busccodigo.Location = new System.Drawing.Point(101, 355);
            this.busccodigo.Name = "busccodigo";
            this.busccodigo.Size = new System.Drawing.Size(36, 23);
            this.busccodigo.TabIndex = 28;
            this.busccodigo.Text = "OK";
            this.busccodigo.UseVisualStyleBackColor = true;
            this.busccodigo.Click += new System.EventHandler(this.busccodigo_Click);
            // 
            // pcodigo
            // 
            this.pcodigo.Location = new System.Drawing.Point(15, 358);
            this.pcodigo.Name = "pcodigo";
            this.pcodigo.Size = new System.Drawing.Size(80, 20);
            this.pcodigo.TabIndex = 29;
            // 
            // pplaca
            // 
            this.pplaca.Location = new System.Drawing.Point(167, 357);
            this.pplaca.Name = "pplaca";
            this.pplaca.Size = new System.Drawing.Size(94, 20);
            this.pplaca.TabIndex = 32;
            // 
            // buscplaca
            // 
            this.buscplaca.Location = new System.Drawing.Point(277, 355);
            this.buscplaca.Name = "buscplaca";
            this.buscplaca.Size = new System.Drawing.Size(38, 23);
            this.buscplaca.TabIndex = 31;
            this.buscplaca.Text = "OK";
            this.buscplaca.UseVisualStyleBackColor = true;
            this.buscplaca.Click += new System.EventHandler(this.buscplaca_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(164, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Placa:";
            // 
            // busctipo
            // 
            this.busctipo.Location = new System.Drawing.Point(482, 353);
            this.busctipo.Name = "busctipo";
            this.busctipo.Size = new System.Drawing.Size(31, 23);
            this.busctipo.TabIndex = 34;
            this.busctipo.Text = "OK";
            this.busctipo.UseVisualStyleBackColor = true;
            this.busctipo.Click += new System.EventHandler(this.busctipo_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(316, 330);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Tipo Veiculo:";
            // 
            // Aberto
            // 
            this.Aberto.Location = new System.Drawing.Point(519, 320);
            this.Aberto.Name = "Aberto";
            this.Aberto.Size = new System.Drawing.Size(75, 23);
            this.Aberto.TabIndex = 36;
            this.Aberto.Text = "Aberto";
            this.Aberto.UseVisualStyleBackColor = true;
            this.Aberto.Click += new System.EventHandler(this.Aberto_Click);
            // 
            // fechado
            // 
            this.fechado.Location = new System.Drawing.Point(519, 349);
            this.fechado.Name = "fechado";
            this.fechado.Size = new System.Drawing.Size(75, 23);
            this.fechado.TabIndex = 37;
            this.fechado.Text = "Fechado";
            this.fechado.UseVisualStyleBackColor = true;
            this.fechado.Click += new System.EventHandler(this.fechado_Click);
            // 
            // todos
            // 
            this.todos.Location = new System.Drawing.Point(519, 379);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(75, 23);
            this.todos.TabIndex = 38;
            this.todos.Text = "Todos";
            this.todos.UseVisualStyleBackColor = true;
            this.todos.Click += new System.EventHandler(this.todos_Click);
            // 
            // ptipo
            // 
            this.ptipo.FormattingEnabled = true;
            this.ptipo.Location = new System.Drawing.Point(323, 355);
            this.ptipo.Name = "ptipo";
            this.ptipo.Size = new System.Drawing.Size(149, 21);
            this.ptipo.TabIndex = 39;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1179, 645);
            this.Controls.Add(this.ptipo);
            this.Controls.Add(this.todos);
            this.Controls.Add(this.fechado);
            this.Controls.Add(this.Aberto);
            this.Controls.Add(this.busctipo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pplaca);
            this.Controls.Add(this.buscplaca);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pcodigo);
            this.Controls.Add(this.busccodigo);
            this.Controls.Add(this.kkk);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgregistro);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gravar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgregistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
            comando.Connection = conn;
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
            fatura.Enabled = false;
            datasaida.Enabled = false;
            datasaida.Text = String.Empty;
            horasaida.Enabled = false;
            horasaida.Text = String.Empty;
            total.Enabled = false;
            total.Text = String.Empty;
            valorpago.Enabled = false;
            valorpago.Text = String.Empty;
            listaGrid();
            listbbox();





            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox placaCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dataEntrada;
        private System.Windows.Forms.TextBox horaentrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.DataGridView dgregistro;
        private System.Windows.Forms.Button fatura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button saida;
        private System.Windows.Forms.TextBox valorpago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox horasaida;
        private System.Windows.Forms.TextBox datasaida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label kkk;
        private System.Windows.Forms.Button busccodigo;
        private System.Windows.Forms.TextBox pcodigo;
        private System.Windows.Forms.TextBox pplaca;
        private System.Windows.Forms.Button buscplaca;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button busctipo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Aberto;
        private System.Windows.Forms.Button fechado;
        private System.Windows.Forms.Button todos;
        private System.Windows.Forms.ComboBox ptipo;
    }
}