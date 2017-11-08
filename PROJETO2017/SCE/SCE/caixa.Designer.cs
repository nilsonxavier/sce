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
            this.datacaixa = new System.Windows.Forms.TextBox();
            this.cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.abcaixa = new System.Windows.Forms.DataGridView();
            this.fechar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.movcaixa = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Abertura.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abcaixa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movcaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // Abertura
            // 
            this.Abertura.Controls.Add(this.tabPage1);
            this.Abertura.Controls.Add(this.tabPage2);
            this.Abertura.Location = new System.Drawing.Point(0, 97);
            this.Abertura.Name = "Abertura";
            this.Abertura.SelectedIndex = 0;
            this.Abertura.Size = new System.Drawing.Size(666, 307);
            this.Abertura.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.abcaixa);
            this.tabPage1.Controls.Add(this.fechar);
            this.tabPage1.Controls.Add(this.excluir);
            this.tabPage1.Controls.Add(this.cancelar);
            this.tabPage1.Controls.Add(this.gravar);
            this.tabPage1.Controls.Add(this.novo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abertura de Caixa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.datacaixa);
            this.panel1.Controls.Add(this.cod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 220);
            this.panel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Data Caixa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // datacaixa
            // 
            this.datacaixa.Location = new System.Drawing.Point(63, 91);
            this.datacaixa.Name = "datacaixa";
            this.datacaixa.Size = new System.Drawing.Size(100, 20);
            this.datacaixa.TabIndex = 41;
            this.datacaixa.TextChanged += new System.EventHandler(this.datacaixa_TextChanged);
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(63, 39);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(68, 20);
            this.cod.TabIndex = 38;
            this.cod.TextChanged += new System.EventHandler(this.cod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(63, 65);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 39;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // abcaixa
            // 
            this.abcaixa.AllowUserToAddRows = false;
            this.abcaixa.AllowUserToDeleteRows = false;
            this.abcaixa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.abcaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abcaixa.Location = new System.Drawing.Point(186, 55);
            this.abcaixa.Name = "abcaixa";
            this.abcaixa.ReadOnly = true;
            this.abcaixa.Size = new System.Drawing.Size(469, 220);
            this.abcaixa.TabIndex = 36;
            // 
            // fechar
            // 
            this.fechar.Image = global::SCE.Properties.Resources.saida;
            this.fechar.Location = new System.Drawing.Point(219, 5);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(45, 43);
            this.fechar.TabIndex = 29;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // excluir
            // 
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Image = global::SCE.Properties.Resources.Excluir;
            this.excluir.Location = new System.Drawing.Point(168, 5);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(45, 43);
            this.excluir.TabIndex = 28;
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cancelar
            // 
            this.cancelar.Image = global::SCE.Properties.Resources.cancelar;
            this.cancelar.Location = new System.Drawing.Point(117, 6);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(45, 42);
            this.cancelar.TabIndex = 27;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // gravar
            // 
            this.gravar.Image = global::SCE.Properties.Resources.salvar;
            this.gravar.Location = new System.Drawing.Point(66, 6);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(45, 43);
            this.gravar.TabIndex = 26;
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // novo
            // 
            this.novo.Image = global::SCE.Properties.Resources.botão;
            this.novo.Location = new System.Drawing.Point(15, 6);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(45, 43);
            this.novo.TabIndex = 25;
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.movcaixa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimento de Caixa";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // movcaixa
            // 
            this.movcaixa.AllowUserToAddRows = false;
            this.movcaixa.AllowUserToDeleteRows = false;
            this.movcaixa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.movcaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movcaixa.Location = new System.Drawing.Point(3, 6);
            this.movcaixa.Name = "movcaixa";
            this.movcaixa.ReadOnly = true;
            this.movcaixa.Size = new System.Drawing.Size(489, 269);
            this.movcaixa.TabIndex = 0;
            this.movcaixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movcaixa_CellContentClick);
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
            this.ClientSize = new System.Drawing.Size(670, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Abertura);
            this.Controls.Add(this.menuStrip1);
            this.Name = "caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caixa";
            this.Load += new System.EventHandler(this.caixa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Abertura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abcaixa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movcaixa)).EndInit();
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
        private System.Windows.Forms.DataGridView abcaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox datacaixa;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.DataGridView movcaixa;
    }
}