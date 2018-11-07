namespace Go.VIEW
{
    partial class TelaNovaTarefaColuna3
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nova tarefa em Done";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(249, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 59);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(12, 285);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(63, 59);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.Location = new System.Drawing.Point(8, 141);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(306, 121);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.Location = new System.Drawing.Point(8, 80);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(306, 25);
            this.txtTitulo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descrição";
            // 
            // TelaNovaTarefaColuna3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(206)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(326, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(882, 115);
            this.Name = "TelaNovaTarefaColuna3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Done";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}