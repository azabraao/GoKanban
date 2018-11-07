namespace Go.VIEW
{
    partial class TelaProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProjeto));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnCriaTarefa2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btnCriaTarefa3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pnlLoginProj = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.btnNewProjt = new System.Windows.Forms.Button();
            this.lblApresentacao2 = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.btnConfigProjeto = new System.Windows.Forms.Button();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.toolTelaProjeto = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionaProjeto = new System.Windows.Forms.Button();
            this.pnlPomodoro = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.lblCronometro2 = new System.Windows.Forms.Label();
            this.pnlTempo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPauseP = new System.Windows.Forms.Button();
            this.btnPlayP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlLoginProj.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlPomodoro.SuspendLayout();
            this.pnlTempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.AllowDrop = true;
            this.pnl1.AutoScroll = true;
            this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl1.Location = new System.Drawing.Point(3, 90);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(323, 457);
            this.pnl1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pnl1);
            this.groupBox1.Controls.Add(this.btnCria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(190, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 572);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCria
            // 
            this.btnCria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(91)))), ((int)(((byte)(138)))));
            this.btnCria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCria.FlatAppearance.BorderSize = 0;
            this.btnCria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCria.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnCria.ForeColor = System.Drawing.Color.White;
            this.btnCria.Location = new System.Drawing.Point(0, 43);
            this.btnCria.Name = "btnCria";
            this.btnCria.Size = new System.Drawing.Size(329, 41);
            this.btnCria.TabIndex = 1;
            this.btnCria.Text = "Nova tarefa";
            this.toolTelaProjeto.SetToolTip(this.btnCria, "Nova tarefa To-Do");
            this.btnCria.UseVisualStyleBackColor = false;
            this.btnCria.Click += new System.EventHandler(this.btnCria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(129, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "TO DO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.pnl2);
            this.groupBox2.Controls.Add(this.btnCriaTarefa2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(539, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 572);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // pnl2
            // 
            this.pnl2.AllowDrop = true;
            this.pnl2.AutoScroll = true;
            this.pnl2.BackColor = System.Drawing.Color.Transparent;
            this.pnl2.Location = new System.Drawing.Point(3, 91);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(318, 457);
            this.pnl2.TabIndex = 0;
            // 
            // btnCriaTarefa2
            // 
            this.btnCriaTarefa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(91)))), ((int)(((byte)(138)))));
            this.btnCriaTarefa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriaTarefa2.FlatAppearance.BorderSize = 0;
            this.btnCriaTarefa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriaTarefa2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnCriaTarefa2.ForeColor = System.Drawing.Color.White;
            this.btnCriaTarefa2.Location = new System.Drawing.Point(0, 44);
            this.btnCriaTarefa2.Name = "btnCriaTarefa2";
            this.btnCriaTarefa2.Size = new System.Drawing.Size(324, 41);
            this.btnCriaTarefa2.TabIndex = 0;
            this.btnCriaTarefa2.Text = "Nova tarefa";
            this.toolTelaProjeto.SetToolTip(this.btnCriaTarefa2, "Nova tarefa Doing");
            this.btnCriaTarefa2.UseVisualStyleBackColor = false;
            this.btnCriaTarefa2.Click += new System.EventHandler(this.btnCriaTarefa2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(122, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "DOING";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 34);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.pnl3);
            this.groupBox3.Controls.Add(this.btnCriaTarefa3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(882, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 572);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // pnl3
            // 
            this.pnl3.AllowDrop = true;
            this.pnl3.AutoScroll = true;
            this.pnl3.BackColor = System.Drawing.Color.Transparent;
            this.pnl3.Location = new System.Drawing.Point(3, 91);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(318, 457);
            this.pnl3.TabIndex = 0;
            // 
            // btnCriaTarefa3
            // 
            this.btnCriaTarefa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(91)))), ((int)(((byte)(138)))));
            this.btnCriaTarefa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriaTarefa3.FlatAppearance.BorderSize = 0;
            this.btnCriaTarefa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriaTarefa3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnCriaTarefa3.ForeColor = System.Drawing.Color.White;
            this.btnCriaTarefa3.Location = new System.Drawing.Point(0, 43);
            this.btnCriaTarefa3.Name = "btnCriaTarefa3";
            this.btnCriaTarefa3.Size = new System.Drawing.Size(326, 42);
            this.btnCriaTarefa3.TabIndex = 0;
            this.btnCriaTarefa3.Text = "Nova terefa";
            this.toolTelaProjeto.SetToolTip(this.btnCriaTarefa3, "Nova tarefa Doing");
            this.btnCriaTarefa3.UseVisualStyleBackColor = false;
            this.btnCriaTarefa3.Click += new System.EventHandler(this.btnCriaTarefa3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(132, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "DONE";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 318);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(521, 57);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pnlLoginProj
            // 
            this.pnlLoginProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.pnlLoginProj.Controls.Add(this.btnLogin);
            this.pnlLoginProj.Controls.Add(this.label11);
            this.pnlLoginProj.Controls.Add(this.label10);
            this.pnlLoginProj.Controls.Add(this.txtSenha);
            this.pnlLoginProj.Location = new System.Drawing.Point(406, 181);
            this.pnlLoginProj.Name = "pnlLoginProj";
            this.pnlLoginProj.Size = new System.Drawing.Size(632, 291);
            this.pnlLoginProj.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(91)))), ((int)(((byte)(138)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(227, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Projetar!";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(82, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(521, 56);
            this.label11.TabIndex = 2;
            this.label11.Text = "PROJETO PROTEGIDO! ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(149, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(227, 134);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(158, 30);
            this.txtSenha.TabIndex = 0;
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Century Gothic", 23.75F, System.Drawing.FontStyle.Bold);
            this.lblApresentacao.Location = new System.Drawing.Point(93, 240);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(307, 38);
            this.lblApresentacao.TabIndex = 0;
            this.lblApresentacao.Text = "ESCOLHA OU CRIE ";
            this.lblApresentacao.Click += new System.EventHandler(this.lblApresentacao_Click);
            // 
            // btnNewProjt
            // 
            this.btnNewProjt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(91)))), ((int)(((byte)(138)))));
            this.btnNewProjt.FlatAppearance.BorderSize = 0;
            this.btnNewProjt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProjt.Font = new System.Drawing.Font("Century Gothic", 25.75F, System.Drawing.FontStyle.Bold);
            this.btnNewProjt.ForeColor = System.Drawing.Color.White;
            this.btnNewProjt.Location = new System.Drawing.Point(101, 392);
            this.btnNewProjt.Name = "btnNewProjt";
            this.btnNewProjt.Size = new System.Drawing.Size(523, 80);
            this.btnNewProjt.TabIndex = 25;
            this.btnNewProjt.Text = "Novo Projeto";
            this.btnNewProjt.UseVisualStyleBackColor = false;
            this.btnNewProjt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblApresentacao2
            // 
            this.lblApresentacao2.AutoSize = true;
            this.lblApresentacao2.Font = new System.Drawing.Font("Century Gothic", 23.75F, System.Drawing.FontStyle.Bold);
            this.lblApresentacao2.Location = new System.Drawing.Point(94, 273);
            this.lblApresentacao2.Name = "lblApresentacao2";
            this.lblApresentacao2.Size = new System.Drawing.Size(489, 38);
            this.lblApresentacao2.TabIndex = 26;
            this.lblApresentacao2.Text = "UM PROJETO PARA COMEÇAR!";
            // 
            // pnlConfig
            // 
            this.pnlConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(165)))), ((int)(((byte)(205)))));
            this.pnlConfig.Controls.Add(this.btnConfigProjeto);
            this.pnlConfig.Controls.Add(this.btnPomodoro);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(87, 741);
            this.pnlConfig.TabIndex = 27;
            this.pnlConfig.Visible = false;
            // 
            // btnConfigProjeto
            // 
            this.btnConfigProjeto.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigProjeto.BackgroundImage = global::Go.Properties.Resources.settings_4;
            this.btnConfigProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigProjeto.FlatAppearance.BorderSize = 0;
            this.btnConfigProjeto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.btnConfigProjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(165)))), ((int)(((byte)(205)))));
            this.btnConfigProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigProjeto.Location = new System.Drawing.Point(12, 10);
            this.btnConfigProjeto.Name = "btnConfigProjeto";
            this.btnConfigProjeto.Size = new System.Drawing.Size(63, 57);
            this.btnConfigProjeto.TabIndex = 3;
            this.toolTelaProjeto.SetToolTip(this.btnConfigProjeto, "Configure seu projeto");
            this.btnConfigProjeto.UseVisualStyleBackColor = false;
            this.btnConfigProjeto.Visible = false;
            this.btnConfigProjeto.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.btnPomodoro.BackgroundImage = global::Go.Properties.Resources.stopwatch_1;
            this.btnPomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPomodoro.FlatAppearance.BorderSize = 0;
            this.btnPomodoro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.btnPomodoro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(165)))), ((int)(((byte)(205)))));
            this.btnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomodoro.Location = new System.Drawing.Point(13, 643);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(62, 55);
            this.btnPomodoro.TabIndex = 2;
            this.toolTelaProjeto.SetToolTip(this.btnPomodoro, "Você tem 25 minutos!!! Será que consegue?");
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Visible = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnConfig_Click_1);
            // 
            // toolTelaProjeto
            // 
            this.toolTelaProjeto.BackColor = System.Drawing.Color.White;
            this.toolTelaProjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(89)))), ((int)(((byte)(134)))));
            this.toolTelaProjeto.IsBalloon = true;
            this.toolTelaProjeto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnAdicionaProjeto
            // 
            this.btnAdicionaProjeto.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionaProjeto.BackgroundImage = global::Go.Properties.Resources.app;
            this.btnAdicionaProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaProjeto.FlatAppearance.BorderSize = 0;
            this.btnAdicionaProjeto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(233)))));
            this.btnAdicionaProjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(233)))));
            this.btnAdicionaProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionaProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaProjeto.Location = new System.Drawing.Point(843, 6);
            this.btnAdicionaProjeto.Name = "btnAdicionaProjeto";
            this.btnAdicionaProjeto.Size = new System.Drawing.Size(55, 50);
            this.btnAdicionaProjeto.TabIndex = 1;
            this.toolTelaProjeto.SetToolTip(this.btnAdicionaProjeto, "ADICIONAR NOVO PROJETO");
            this.btnAdicionaProjeto.UseVisualStyleBackColor = false;
            this.btnAdicionaProjeto.Visible = false;
            this.btnAdicionaProjeto.Click += new System.EventHandler(this.btnAdicionaProjeto_Click);
            // 
            // pnlPomodoro
            // 
            this.pnlPomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.pnlPomodoro.Controls.Add(this.btnIniciar);
            this.pnlPomodoro.Controls.Add(this.btnParar);
            this.pnlPomodoro.Controls.Add(this.btnPausar);
            this.pnlPomodoro.Controls.Add(this.label5);
            this.pnlPomodoro.Controls.Add(this.label4);
            this.pnlPomodoro.Controls.Add(this.lblCronometro);
            this.pnlPomodoro.Location = new System.Drawing.Point(3, 507);
            this.pnlPomodoro.Name = "pnlPomodoro";
            this.pnlPomodoro.Size = new System.Drawing.Size(253, 195);
            this.pnlPomodoro.TabIndex = 30;
            this.pnlPomodoro.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImage = global::Go.Properties.Resources.play;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(39, 148);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(40, 41);
            this.btnIniciar.TabIndex = 31;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnParar
            // 
            this.btnParar.BackgroundImage = global::Go.Properties.Resources.stop;
            this.btnParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParar.FlatAppearance.BorderSize = 0;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Location = new System.Drawing.Point(166, 148);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(41, 41);
            this.btnParar.TabIndex = 33;
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackgroundImage = global::Go.Properties.Resources.pause;
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Location = new System.Drawing.Point(101, 148);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(42, 41);
            this.btnPausar.TabIndex = 32;
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 30.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(220, -13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 47);
            this.label5.TabIndex = 31;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 34);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pomodoro Timer";
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Century Gothic", 25.75F, System.Drawing.FontStyle.Bold);
            this.lblCronometro.ForeColor = System.Drawing.Color.White;
            this.lblCronometro.Location = new System.Drawing.Point(44, 88);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(158, 41);
            this.lblCronometro.TabIndex = 0;
            this.lblCronometro.Text = "25:00:00";
            this.lblCronometro.Click += new System.EventHandler(this.lblCronometro_Click);
            // 
            // lblCronometro2
            // 
            this.lblCronometro2.AutoSize = true;
            this.lblCronometro2.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblCronometro2.ForeColor = System.Drawing.Color.White;
            this.lblCronometro2.Location = new System.Drawing.Point(3, 1);
            this.lblCronometro2.Name = "lblCronometro2";
            this.lblCronometro2.Size = new System.Drawing.Size(20, 29);
            this.lblCronometro2.TabIndex = 31;
            this.lblCronometro2.Text = ".";
            // 
            // pnlTempo
            // 
            this.pnlTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.pnlTempo.Controls.Add(this.lblCronometro2);
            this.pnlTempo.Location = new System.Drawing.Point(88, 669);
            this.pnlTempo.Name = "pnlTempo";
            this.pnlTempo.Size = new System.Drawing.Size(127, 33);
            this.pnlTempo.TabIndex = 32;
            this.pnlTempo.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Go.Properties.Resources.locked;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1313, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 52);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1251, 612);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 93);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 465);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnPauseP
            // 
            this.btnPauseP.BackgroundImage = global::Go.Properties.Resources.pause;
            this.btnPauseP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPauseP.FlatAppearance.BorderSize = 0;
            this.btnPauseP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseP.Location = new System.Drawing.Point(117, 640);
            this.btnPauseP.Name = "btnPauseP";
            this.btnPauseP.Size = new System.Drawing.Size(23, 23);
            this.btnPauseP.TabIndex = 34;
            this.btnPauseP.UseVisualStyleBackColor = true;
            this.btnPauseP.Visible = false;
            this.btnPauseP.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnPlayP
            // 
            this.btnPlayP.BackgroundImage = global::Go.Properties.Resources.play;
            this.btnPlayP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayP.FlatAppearance.BorderSize = 0;
            this.btnPlayP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayP.Location = new System.Drawing.Point(88, 640);
            this.btnPlayP.Name = "btnPlayP";
            this.btnPlayP.Size = new System.Drawing.Size(23, 23);
            this.btnPlayP.TabIndex = 33;
            this.btnPlayP.UseVisualStyleBackColor = true;
            this.btnPlayP.Visible = false;
            this.btnPlayP.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // TelaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 758);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlPomodoro);
            this.Controls.Add(this.pnlTempo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblApresentacao2);
            this.Controls.Add(this.btnNewProjt);
            this.Controls.Add(this.pnlLoginProj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblApresentacao);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAdicionaProjeto);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPauseP);
            this.Controls.Add(this.btnPlayP);
            this.DoubleBuffered = true;
            this.Name = "TelaProjeto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaProjetos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlLoginProj.ResumeLayout(false);
            this.pnlLoginProj.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlPomodoro.ResumeLayout(false);
            this.pnlPomodoro.PerformLayout();
            this.pnlTempo.ResumeLayout(false);
            this.pnlTempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriaTarefa2;
        private System.Windows.Forms.Button btnCria;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdicionaProjeto;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnConfigProjeto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnCriaTarefa3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel pnlLoginProj;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewProjt;
        private System.Windows.Forms.Label lblApresentacao2;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTelaProjeto;
        private System.Windows.Forms.Panel pnlPomodoro;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCronometro2;
        private System.Windows.Forms.Panel pnlTempo;
        private System.Windows.Forms.Button btnPlayP;
        private System.Windows.Forms.Button btnPauseP;
    }
}