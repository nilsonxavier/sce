namespace SCE
{
    partial class consultipoveic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpveiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBDDataSet = new SCE.SGBDDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new SCE.SGBDDataSetTableAdapters.usuarioTableAdapter();
            this.tpveiculosTableAdapter = new SCE.SGBDDataSetTableAdapters.tpveiculosTableAdapter();
            this.dgtipo = new System.Windows.Forms.DataGridView();
            this.TODOS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.ok1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpveiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtipo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.label2.Location = new System.Drawing.Point(128, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "de Tipo de Veiculos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(161, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar";
            // 
            // tpveiculosBindingSource
            // 
            this.tpveiculosBindingSource.DataMember = "tpveiculos";
            this.tpveiculosBindingSource.DataSource = this.sGBDDataSet;
            // 
            // sGBDDataSet
            // 
            this.sGBDDataSet.DataSetName = "SGBDDataSet";
            this.sGBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.sGBDDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tpveiculosTableAdapter
            // 
            this.tpveiculosTableAdapter.ClearBeforeFill = true;
            // 
            // dgtipo
            // 
            this.dgtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtipo.Location = new System.Drawing.Point(0, 167);
            this.dgtipo.Name = "dgtipo";
            this.dgtipo.Size = new System.Drawing.Size(442, 187);
            this.dgtipo.TabIndex = 6;
            // 
            // TODOS
            // 
            this.TODOS.Location = new System.Drawing.Point(257, 136);
            this.TODOS.Name = "TODOS";
            this.TODOS.Size = new System.Drawing.Size(60, 25);
            this.TODOS.TabIndex = 28;
            this.TODOS.Text = "TODOS";
            this.TODOS.UseVisualStyleBackColor = true;
            this.TODOS.Click += new System.EventHandler(this.TODOS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pesquisa______________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo de Veiculo:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(102, 141);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 25;
            // 
            // ok1
            // 
            this.ok1.Location = new System.Drawing.Point(208, 136);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(30, 25);
            this.ok1.TabIndex = 24;
            this.ok1.Text = "OK";
            this.ok1.UseVisualStyleBackColor = true;
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // consultipoveic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(452, 354);
            this.Controls.Add(this.TODOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.dgtipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "consultipoveic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultipoveic";
            this.Load += new System.EventHandler(this.consultipoveic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpveiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private SGBDDataSet sGBDDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private SGBDDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource tpveiculosBindingSource;
        private SGBDDataSetTableAdapters.tpveiculosTableAdapter tpveiculosTableAdapter;
        private System.Windows.Forms.DataGridView dgtipo;
        private System.Windows.Forms.Button TODOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button ok1;
    }
}