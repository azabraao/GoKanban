namespace Go.VIEW
{
    partial class TelaConfigProjeto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnDesconfidencializar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(433, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(28, 126);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(411, 170);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(23, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 28);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.DoubleClick += new System.EventHandler(this.lblTitulo_DoubleClick);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(28, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(232, 26);
            this.txtTitulo.TabIndex = 10;
            this.txtTitulo.Visible = false;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(349, 354);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 43);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "x";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = global::Go.Properties.Resources.list;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Location = new System.Drawing.Point(28, 320);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(79, 84);
            this.btnRelatorio.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRelatorio, "Relatório");
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnDesconfidencializar
            // 
            this.btnDesconfidencializar.BackgroundImage = global::Go.Properties.Resources.locked_1;
            this.btnDesconfidencializar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesconfidencializar.FlatAppearance.BorderSize = 0;
            this.btnDesconfidencializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconfidencializar.Location = new System.Drawing.Point(274, 340);
            this.btnDesconfidencializar.Name = "btnDesconfidencializar";
            this.btnDesconfidencializar.Size = new System.Drawing.Size(58, 57);
            this.btnDesconfidencializar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnDesconfidencializar, "Retirar proteção");
            this.btnDesconfidencializar.UseVisualStyleBackColor = true;
            this.btnDesconfidencializar.Click += new System.EventHandler(this.btnDesconfidencializar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Go.Properties.Resources.locked1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(218, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 57);
            this.button2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button2, "Inserir proteção");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(113, 326);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 71);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descrição";
            // 
            // telaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(465, 416);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnDesconfidencializar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaUsuario";
            this.Load += new System.EventHandler(this.telaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDesconfidencializar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
    }
}