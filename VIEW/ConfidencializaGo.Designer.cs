namespace Go.VIEW
{
    partial class ConfidencializaGo
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
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.txtRepeteSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(92, 174);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(78, 31);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // txtRepeteSenha
            // 
            this.txtRepeteSenha.Location = new System.Drawing.Point(92, 119);
            this.txtRepeteSenha.Name = "txtRepeteSenha";
            this.txtRepeteSenha.Size = new System.Drawing.Size(221, 20);
            this.txtRepeteSenha.TabIndex = 2;
            this.txtRepeteSenha.TextChanged += new System.EventHandler(this.txtRepeteSenha_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(92, 79);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(221, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Repita:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConfidencializaGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRepeteSenha);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Name = "ConfidencializaGo";
            this.Text = "telaCadastroUsuario";
            this.Load += new System.EventHandler(this.telaCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.TextBox txtRepeteSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}