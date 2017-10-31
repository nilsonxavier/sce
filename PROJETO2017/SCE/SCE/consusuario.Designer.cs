namespace SCE
{
    partial class consusuario
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
            this.components = new System.ComponentModel.Container();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBDDataSet = new SCE.SGBDDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuarioTableAdapter = new SCE.SGBDDataSetTableAdapters.usuarioTableAdapter();
            this.dgusuario = new System.Windows.Forms.DataGridView();
            this.ok1 = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.ok2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TODOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBDDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.sGBDDataSet;
            // 
            // sGBDDataSet
            // 
            this.sGBDDataSet.DataSetName = "SGBDDataSet";
            this.sGBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(263, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultar Usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(137, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // dgusuario
            // 
            this.dgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuario.Location = new System.Drawing.Point(0, 175);
            this.dgusuario.Name = "dgusuario";
            this.dgusuario.Size = new System.Drawing.Size(580, 183);
            this.dgusuario.TabIndex = 15;
            // 
            // ok1
            // 
            this.ok1.Location = new System.Drawing.Point(184, 144);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(30, 25);
            this.ok1.TabIndex = 16;
            this.ok1.Text = "OK";
            this.ok1.UseVisualStyleBackColor = true;
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(78, 149);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Usuario:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(276, 147);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 20;
            // 
            // ok2
            // 
            this.ok2.Location = new System.Drawing.Point(449, 142);
            this.ok2.Name = "ok2";
            this.ok2.Size = new System.Drawing.Size(30, 25);
            this.ok2.TabIndex = 19;
            this.ok2.Text = "OK";
            this.ok2.UseVisualStyleBackColor = true;
            this.ok2.Click += new System.EventHandler(this.ok2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pesquisa_________________________________________________________________________" +
    "_____________";
            // 
            // TODOS
            // 
            this.TODOS.Location = new System.Drawing.Point(498, 142);
            this.TODOS.Name = "TODOS";
            this.TODOS.Size = new System.Drawing.Size(60, 25);
            this.TODOS.TabIndex = 23;
            this.TODOS.Text = "TODOS";
            this.TODOS.UseVisualStyleBackColor = true;
            this.TODOS.Click += new System.EventHandler(this.TODOS_Click);
            // 
            // consusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 359);
            this.Controls.Add(this.TODOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ok2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.dgusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "consusuario";
            this.Text = "consusuario";
            this.Load += new System.EventHandler(this.consusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBDDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private SGBDDataSet sGBDDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private SGBDDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridView dgusuario;
        private System.Windows.Forms.Button ok1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button ok2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TODOS;
    }
}