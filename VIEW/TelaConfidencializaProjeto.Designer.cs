namespace Go.VIEW
{
    partial class TelaConfidencializaProjeto
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtRepeteSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.txtLembrete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Repita:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSenha.Location = new System.Drawing.Point(34, 38);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(267, 34);
            this.txtSenha.TabIndex = 9;
            // 
            // txtRepeteSenha
            // 
            this.txtRepeteSenha.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtRepeteSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRepeteSenha.Location = new System.Drawing.Point(34, 118);
            this.txtRepeteSenha.Name = "txtRepeteSenha";
            this.txtRepeteSenha.PasswordChar = '*';
            this.txtRepeteSenha.Size = new System.Drawing.Size(267, 34);
            this.txtRepeteSenha.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(216, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 60);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnCadastrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(44, 276);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(59, 60);
            this.btnCadastrarUsuario.TabIndex = 7;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // txtLembrete
            // 
            this.txtLembrete.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.txtLembrete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLembrete.Location = new System.Drawing.Point(32, 184);
            this.txtLembrete.Multiline = true;
            this.txtLembrete.Name = "txtLembrete";
            this.txtLembrete.Size = new System.Drawing.Size(269, 77);
            this.txtLembrete.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lembrete:";
            // 
            // ConfidencializaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 348);
            this.Controls.Add(this.txtLembrete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRepeteSenha);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfidencializaProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfidencializaGo";
            this.Load += new System.EventHandler(this.ConfidencializaProjeto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtRepeteSenha;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLembrete;
        private System.Windows.Forms.Label label1;
    }
}