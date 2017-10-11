namespace SCE
{
    partial class conf
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sgbdDataSet1 = new SCE.SGBDDataSet();
            this.Gravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vaga = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgbdDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCE.Properties.Resources.cars_icon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(138, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Configuração";
            // 
            // sgbdDataSet1
            // 
            this.sgbdDataSet1.DataSetName = "SGBDDataSet";
            this.sgbdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Gravar
            // 
            this.Gravar.Location = new System.Drawing.Point(124, 193);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(75, 23);
            this.Gravar.TabIndex = 17;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantida Maxima de Vagas:";
            // 
            // vaga
            // 
            this.vaga.Location = new System.Drawing.Point(37, 148);
            this.vaga.Name = "vaga";
            this.vaga.Size = new System.Drawing.Size(137, 20);
            this.vaga.TabIndex = 19;
            // 
            // conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.vaga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "conf";
            this.Text = "conf";
            this.Load += new System.EventHandler(this.conf_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgbdDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private SGBDDataSet sgbdDataSet1;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vaga;
    }
}