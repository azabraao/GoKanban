namespace Go.VIEW
{
    partial class TelaNovoProjeto
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnGeraProjeto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(87, 37);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(400, 27);
            this.txtTitulo.TabIndex = 7;
            // 
            // btnGeraProjeto
            // 
            this.btnGeraProjeto.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnGeraProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeraProjeto.FlatAppearance.BorderSize = 0;
            this.btnGeraProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeraProjeto.Location = new System.Drawing.Point(404, 236);
            this.btnGeraProjeto.Name = "btnGeraProjeto";
            this.btnGeraProjeto.Size = new System.Drawing.Size(63, 60);
            this.btnGeraProjeto.TabIndex = 10;
            this.btnGeraProjeto.UseVisualStyleBackColor = true;
            this.btnGeraProjeto.Click += new System.EventHandler(this.btnGeraProjeto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(91, 95);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(396, 135);
            this.txtDescricao.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(408, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 60);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(95, 288);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(231, 20);
            this.dtpInicio.TabIndex = 14;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(95, 348);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(231, 20);
            this.dtpFim.TabIndex = 15;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "INICIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "FIM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Go.Properties.Resources.npROJETO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 422);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmNovoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(165)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(534, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeraProjeto);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(102, 190);
            this.Name = "frmNovoProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Projeto";
            this.Load += new System.EventHandler(this.frmNovoProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnGeraProjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}