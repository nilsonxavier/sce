namespace SCE
{
    partial class caixa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Abertura = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.horaentrada = new System.Windows.Forms.TextBox();
            this.cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placaCarro = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datasaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Abertura.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            // 
            // Abertura
            // 
            this.Abertura.Controls.Add(this.tabPage1);
            this.Abertura.Controls.Add(this.tabPage2);
            this.Abertura.Location = new System.Drawing.Point(0, 97);
            this.Abertura.Name = "Abertura";
            this.Abertura.SelectedIndex = 0;
            this.Abertura.Size = new System.Drawing.Size(640, 307);
            this.Abertura.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.fechar);
            this.tabPage1.Controls.Add(this.excluir);
            this.tabPage1.Controls.Add(this.cancelar);
            this.tabPage1.Controls.Add(this.gravar);
            this.tabPage1.Controls.Add(this.novo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abertura de Caixa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.horaentrada);
            this.panel1.Controls.Add(this.cod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.placaCarro);
            this.panel1.Location = new System.Drawing.Point(15, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 150);
            this.panel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Hora Entrada";
            // 
            // horaentrada
            // 
            this.horaentrada.Location = new System.Drawing.Point(84, 97);
            this.horaentrada.Name = "horaentrada";
            this.horaentrada.Size = new System.Drawing.Size(100, 20);
            this.horaentrada.TabIndex = 41;
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(84, 37);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(68, 20);
            this.cod.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome";
            // 
            // placaCarro
            // 
            this.placaCarro.Location = new System.Drawing.Point(84, 63);
            this.placaCarro.Name = "placaCarro";
            this.placaCarro.Size = new System.Drawing.Size(100, 20);
            this.placaCarro.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.placa,
            this.data,
            this.hora,
            this.Datasaida,
            this.horasaida,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(219, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            // 
            // placa
            // 
            this.placa.HeaderText = "placa";
            this.placa.Name = "placa";
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.Name = "data";
            // 
            // hora
            // 
            this.hora.HeaderText = "hora";
            this.hora.Name = "hora";
            // 
            // Datasaida
            // 
            this.Datasaida.HeaderText = "Data Saida";
            this.Datasaida.Name = "Datasaida";
            // 
            // horasaida
            // 
            this.horasaida.HeaderText = "Hora Saida";
            this.horasaida.Name = "horasaida";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Geral";
            this.Valor.Name = "Valor";
            // 
            // fechar
            // 
            this.fechar.Image = global::SCE.Properties.Resources.saida;
            this.fechar.Location = new System.Drawing.Point(287, 38);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(45, 43);
            this.fechar.TabIndex = 29;
            this.fechar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Image = global::SCE.Properties.Resources.Excluir;
            this.excluir.Location = new System.Drawing.Point(236, 38);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(45, 43);
            this.excluir.TabIndex = 28;
            this.excluir.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.Image = global::SCE.Properties.Resources.cancelar;
            this.cancelar.Location = new System.Drawing.Point(185, 39);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(45, 42);
            this.cancelar.TabIndex = 27;
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // gravar
            // 
            this.gravar.Image = global::SCE.Properties.Resources.salvar;
            this.gravar.Location = new System.Drawing.Point(134, 39);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(45, 43);
            this.gravar.TabIndex = 26;
            this.gravar.UseVisualStyleBackColor = true;
            // 
            // novo
            // 
            this.novo.Image = global::SCE.Properties.Resources.botão;
            this.novo.Location = new System.Drawing.Point(83, 39);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(45, 43);
            this.novo.TabIndex = 25;
            this.novo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimento de Caixa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(8, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(587, 210);
            this.dataGridView2.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "hora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Saida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Hora Saida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor Geral";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Image = global::SCE.Properties.Resources.saida;
            this.button1.Location = new System.Drawing.Point(354, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SCE.Properties.Resources.Excluir;
            this.button2.Location = new System.Drawing.Point(303, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 33;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::SCE.Properties.Resources.cancelar;
            this.button3.Location = new System.Drawing.Point(252, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 42);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::SCE.Properties.Resources.salvar;
            this.button4.Location = new System.Drawing.Point(201, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 43);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::SCE.Properties.Resources.botão;
            this.button5.Location = new System.Drawing.Point(150, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 43);
            this.button5.TabIndex = 30;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(185, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(291, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Caixa";
            // 
            // caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(640, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Abertura);
            this.Controls.Add(this.menuStrip1);
            this.Name = "caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caixa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Abertura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.TabControl Abertura;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datasaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox horaentrada;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox placaCarro;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}