namespace Go.VIEW
{
    partial class TelaNovaTarefaColuna1
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.Location = new System.Drawing.Point(12, 80);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(305, 25);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.Location = new System.Drawing.Point(12, 147);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(305, 121);
            this.txtDescricao.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(15, 296);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(63, 59);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(254, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 59);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.label4.Location = new System.Drawing.Point(55, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nova tarefa em To Do";
            // 
            // TelaNovaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(206)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(329, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(190, 115);
            this.Name = "TelaNovaTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaNovaTarefa";
            this.Load += new System.EventHandler(this.TelaNovaTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}