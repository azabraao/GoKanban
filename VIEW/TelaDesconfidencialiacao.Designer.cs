namespace Go.VIEW
{
    partial class TelaDesconfidencialiacao
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLembrete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lembrete";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(12, 170);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(284, 26);
            this.txtSenha.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(12, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 81);
            this.btnOk.TabIndex = 3;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(209, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 81);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLembrete
            // 
            this.lblLembrete.AutoSize = true;
            this.lblLembrete.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLembrete.Location = new System.Drawing.Point(32, 99);
            this.lblLembrete.Name = "lblLembrete";
            this.lblLembrete.Size = new System.Drawing.Size(82, 19);
            this.lblLembrete.TabIndex = 5;
            this.lblLembrete.Text = "Lembrete:";
            // 
            // Desconfidencialiacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(206)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(308, 336);
            this.Controls.Add(this.lblLembrete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desconfidencialiacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Desconfidencialiacao";
            this.Load += new System.EventHandler(this.Desconfidencialiacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLembrete;
    }
}