namespace SCE
{
    partial class cadcliente
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
            this.fechar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTiposDeVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechar
            // 
            this.fechar.Image = global::SCE.Properties.Resources.saida;
            this.fechar.Location = new System.Drawing.Point(265, 299);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(45, 43);
            this.fechar.TabIndex = 19;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // excluir
            // 
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Image = global::SCE.Properties.Resources.Excluir;
            this.excluir.Location = new System.Drawing.Point(214, 300);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(45, 43);
            this.excluir.TabIndex = 18;
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cancelar
            // 
            this.cancelar.Image = global::SCE.Properties.Resources.cancelar;
            this.cancelar.Location = new System.Drawing.Point(163, 300);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(45, 42);
            this.cancelar.TabIndex = 17;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // gravar
            // 
            this.gravar.Image = global::SCE.Properties.Resources.salvar;
            this.gravar.Location = new System.Drawing.Point(112, 300);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(45, 43);
            this.gravar.TabIndex = 16;
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // novo
            // 
            this.novo.Image = global::SCE.Properties.Resources.botão;
            this.novo.Location = new System.Drawing.Point(61, 300);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(45, 42);
            this.novo.TabIndex = 15;
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.telefone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.n);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.endereco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cpf);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 186);
            this.panel1.TabIndex = 14;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(241, 121);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(144, 20);
            this.email.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email:";
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(62, 121);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(132, 20);
            this.telefone.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telefone:";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(341, 83);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(44, 20);
            this.n.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nº:";
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(62, 83);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(248, 20);
            this.endereco.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enderço:";
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(214, 15);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(171, 20);
            this.cpf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(61, 47);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(324, 20);
            this.nome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome:";
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
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(227, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "de Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(42, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(153, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 13;
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
            this.consultarTiposDeVeiculosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarTiposDeVeiculosToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarTiposDeVeiculosToolStripMenuItem.Click += new System.EventHandler(this.consultarTiposDeVeiculosToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // cadcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(409, 370);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gravar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "cadcliente";
            this.Text = "cadcliente";
            this.Load += new System.EventHandler(this.cadcliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTiposDeVeiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}