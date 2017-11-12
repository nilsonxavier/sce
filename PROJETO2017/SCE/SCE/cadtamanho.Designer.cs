namespace SCE
{
    partial class cadtamanho
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
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTiposDeVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTiposDeVeiculosToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarTiposDeVeiculosToolStripMenuItem
            // 
            this.consultarTiposDeVeiculosToolStripMenuItem.Name = "consultarTiposDeVeiculosToolStripMenuItem";
            this.consultarTiposDeVeiculosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.consultarTiposDeVeiculosToolStripMenuItem.Text = "Consultar Categoria";
            this.consultarTiposDeVeiculosToolStripMenuItem.Click += new System.EventHandler(this.consultarTiposDeVeiculosToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(129, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "de Categoria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(164, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cadastro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 79);
            this.panel1.TabIndex = 29;
            // 
            // cor
            // 
            this.cor.Location = new System.Drawing.Point(61, 47);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(184, 20);
            this.cor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Modelo:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(61, 15);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(93, 20);
            this.codigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // fechar
            // 
            this.fechar.Image = global::SCE.Properties.Resources.saida;
            this.fechar.Location = new System.Drawing.Point(251, 185);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(45, 43);
            this.fechar.TabIndex = 28;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // excluir
            // 
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Image = global::SCE.Properties.Resources.Excluir;
            this.excluir.Location = new System.Drawing.Point(200, 185);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(45, 43);
            this.excluir.TabIndex = 27;
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cancelar
            // 
            this.cancelar.Image = global::SCE.Properties.Resources.cancelar;
            this.cancelar.Location = new System.Drawing.Point(149, 186);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(45, 42);
            this.cancelar.TabIndex = 26;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // gravar
            // 
            this.gravar.Image = global::SCE.Properties.Resources.salvar;
            this.gravar.Location = new System.Drawing.Point(98, 185);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(45, 43);
            this.gravar.TabIndex = 25;
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // novo
            // 
            this.novo.Image = global::SCE.Properties.Resources.botão;
            this.novo.Location = new System.Drawing.Point(47, 186);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(45, 42);
            this.novo.TabIndex = 24;
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // cadtamanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gravar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "cadtamanho";
            this.Text = "cadtamanho";
            this.Load += new System.EventHandler(this.cadtamanho_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTiposDeVeiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button novo;
    }
}