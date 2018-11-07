namespace Go.VIEW
{
    partial class TelaConfigTarefa
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQtdDias = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDarkSalmon = new System.Windows.Forms.Button();
            this.btnSalmon = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnYellowGreen = new System.Windows.Forms.Button();
            this.btnChartreuse = new System.Windows.Forms.Button();
            this.btnLightGreen = new System.Windows.Forms.Button();
            this.btnGoldrod = new System.Windows.Forms.Button();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnSkyBlue = new System.Windows.Forms.Button();
            this.btnDeepSkyBlue = new System.Windows.Forms.Button();
            this.btnDarkViolet = new System.Windows.Forms.Button();
            this.btnOrchid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCalendario = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.pnlCalendario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTitulo.Location = new System.Drawing.Point(6, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(271, 20);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlteraTitulo);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDescricao.Location = new System.Drawing.Point(6, 72);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(271, 176);
            this.txtDescricao.TabIndex = 1;
            // 
            // cmbColuna
            // 
            this.cmbColuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbColuna.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.cmbColuna.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "To Do",
            "Doing",
            "Done"});
            this.cmbColuna.Location = new System.Drawing.Point(407, 303);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(129, 31);
            this.cmbColuna.TabIndex = 4;
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.cmbColuna_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coluna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Início:";
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpFim.Location = new System.Drawing.Point(7, 76);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(261, 24);
            this.dtpFim.TabIndex = 13;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpInicio.Location = new System.Drawing.Point(7, 26);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(261, 24);
            this.dtpInicio.TabIndex = 12;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fim";
            // 
            // lblQtdDias
            // 
            this.lblQtdDias.AutoSize = true;
            this.lblQtdDias.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblQtdDias.Location = new System.Drawing.Point(6, 76);
            this.lblQtdDias.Name = "lblQtdDias";
            this.lblQtdDias.Size = new System.Drawing.Size(50, 19);
            this.lblQtdDias.TabIndex = 19;
            this.lblQtdDias.Text = "LABÉL";
            this.lblQtdDias.Click += new System.EventHandler(this.lblQtdDias_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(63, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 19);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Data final:";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDataFinal.Location = new System.Drawing.Point(63, 42);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(42, 19);
            this.lblDataFinal.TabIndex = 17;
            this.lblDataFinal.Text = "label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(426, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cronômetro";
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblCronometro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.lblCronometro.Location = new System.Drawing.Point(417, 395);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(158, 41);
            this.lblCronometro.TabIndex = 23;
            this.lblCronometro.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDarkSalmon
            // 
            this.btnDarkSalmon.FlatAppearance.BorderSize = 0;
            this.btnDarkSalmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkSalmon.Location = new System.Drawing.Point(11, 32);
            this.btnDarkSalmon.Name = "btnDarkSalmon";
            this.btnDarkSalmon.Size = new System.Drawing.Size(40, 31);
            this.btnDarkSalmon.TabIndex = 28;
            this.btnDarkSalmon.UseVisualStyleBackColor = true;
            this.btnDarkSalmon.Click += new System.EventHandler(this.btnDarkSalmon_Click);
            // 
            // btnSalmon
            // 
            this.btnSalmon.FlatAppearance.BorderSize = 0;
            this.btnSalmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalmon.Location = new System.Drawing.Point(58, 31);
            this.btnSalmon.Name = "btnSalmon";
            this.btnSalmon.Size = new System.Drawing.Size(40, 31);
            this.btnSalmon.TabIndex = 29;
            this.btnSalmon.UseVisualStyleBackColor = true;
            this.btnSalmon.Click += new System.EventHandler(this.btnSalmon_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.FlatAppearance.BorderSize = 0;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(12, 106);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(40, 31);
            this.btnOrange.TabIndex = 30;
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnYellowGreen
            // 
            this.btnYellowGreen.FlatAppearance.BorderSize = 0;
            this.btnYellowGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellowGreen.Location = new System.Drawing.Point(58, 143);
            this.btnYellowGreen.Name = "btnYellowGreen";
            this.btnYellowGreen.Size = new System.Drawing.Size(40, 31);
            this.btnYellowGreen.TabIndex = 31;
            this.btnYellowGreen.UseVisualStyleBackColor = true;
            this.btnYellowGreen.Click += new System.EventHandler(this.btnYellowGreen_Click);
            // 
            // btnChartreuse
            // 
            this.btnChartreuse.FlatAppearance.BorderSize = 0;
            this.btnChartreuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChartreuse.Location = new System.Drawing.Point(104, 31);
            this.btnChartreuse.Name = "btnChartreuse";
            this.btnChartreuse.Size = new System.Drawing.Size(40, 31);
            this.btnChartreuse.TabIndex = 32;
            this.btnChartreuse.UseVisualStyleBackColor = true;
            this.btnChartreuse.Click += new System.EventHandler(this.btnChartreuse_Click);
            // 
            // btnLightGreen
            // 
            this.btnLightGreen.FlatAppearance.BorderSize = 0;
            this.btnLightGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightGreen.Location = new System.Drawing.Point(104, 143);
            this.btnLightGreen.Name = "btnLightGreen";
            this.btnLightGreen.Size = new System.Drawing.Size(40, 31);
            this.btnLightGreen.TabIndex = 33;
            this.btnLightGreen.UseVisualStyleBackColor = true;
            this.btnLightGreen.Click += new System.EventHandler(this.btnLightGreen_Click_1);
            // 
            // btnGoldrod
            // 
            this.btnGoldrod.FlatAppearance.BorderSize = 0;
            this.btnGoldrod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoldrod.Location = new System.Drawing.Point(104, 106);
            this.btnGoldrod.Name = "btnGoldrod";
            this.btnGoldrod.Size = new System.Drawing.Size(40, 31);
            this.btnGoldrod.TabIndex = 34;
            this.btnGoldrod.UseVisualStyleBackColor = true;
            this.btnGoldrod.Click += new System.EventHandler(this.btnGoldrod_Click);
            // 
            // btnGold
            // 
            this.btnGold.FlatAppearance.BorderSize = 0;
            this.btnGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGold.Location = new System.Drawing.Point(104, 69);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(40, 31);
            this.btnGold.TabIndex = 35;
            this.btnGold.UseVisualStyleBackColor = true;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnSkyBlue
            // 
            this.btnSkyBlue.FlatAppearance.BorderSize = 0;
            this.btnSkyBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkyBlue.Location = new System.Drawing.Point(12, 69);
            this.btnSkyBlue.Name = "btnSkyBlue";
            this.btnSkyBlue.Size = new System.Drawing.Size(40, 31);
            this.btnSkyBlue.TabIndex = 36;
            this.btnSkyBlue.UseVisualStyleBackColor = true;
            this.btnSkyBlue.Click += new System.EventHandler(this.btnSkyBlue_Click);
            // 
            // btnDeepSkyBlue
            // 
            this.btnDeepSkyBlue.FlatAppearance.BorderSize = 0;
            this.btnDeepSkyBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeepSkyBlue.Location = new System.Drawing.Point(58, 69);
            this.btnDeepSkyBlue.Name = "btnDeepSkyBlue";
            this.btnDeepSkyBlue.Size = new System.Drawing.Size(40, 31);
            this.btnDeepSkyBlue.TabIndex = 37;
            this.btnDeepSkyBlue.UseVisualStyleBackColor = true;
            this.btnDeepSkyBlue.Click += new System.EventHandler(this.btnDeepSkyBlue_Click);
            // 
            // btnDarkViolet
            // 
            this.btnDarkViolet.FlatAppearance.BorderSize = 0;
            this.btnDarkViolet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkViolet.Location = new System.Drawing.Point(58, 106);
            this.btnDarkViolet.Name = "btnDarkViolet";
            this.btnDarkViolet.Size = new System.Drawing.Size(40, 31);
            this.btnDarkViolet.TabIndex = 38;
            this.btnDarkViolet.UseVisualStyleBackColor = true;
            this.btnDarkViolet.Click += new System.EventHandler(this.btnDarkViolet_Click);
            // 
            // btnOrchid
            // 
            this.btnOrchid.FlatAppearance.BorderSize = 0;
            this.btnOrchid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrchid.Location = new System.Drawing.Point(12, 143);
            this.btnOrchid.Name = "btnOrchid";
            this.btnOrchid.Size = new System.Drawing.Size(40, 31);
            this.btnOrchid.TabIndex = 39;
            this.btnOrchid.UseVisualStyleBackColor = true;
            this.btnOrchid.Click += new System.EventHandler(this.btnOrchid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDarkSalmon);
            this.groupBox1.Controls.Add(this.btnSalmon);
            this.groupBox1.Controls.Add(this.btnOrange);
            this.groupBox1.Controls.Add(this.btnYellowGreen);
            this.groupBox1.Controls.Add(this.btnChartreuse);
            this.groupBox1.Controls.Add(this.btnLightGreen);
            this.groupBox1.Controls.Add(this.btnOrchid);
            this.groupBox1.Controls.Add(this.btnGoldrod);
            this.groupBox1.Controls.Add(this.btnDarkViolet);
            this.groupBox1.Controls.Add(this.btnGold);
            this.groupBox1.Controls.Add(this.btnDeepSkyBlue);
            this.groupBox1.Controls.Add(this.btnSkyBlue);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(407, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 191);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor da Tarefa";
            // 
            // pnlCalendario
            // 
            this.pnlCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.pnlCalendario.Controls.Add(this.button4);
            this.pnlCalendario.Controls.Add(this.label3);
            this.pnlCalendario.Controls.Add(this.dtpInicio);
            this.pnlCalendario.Controls.Add(this.button3);
            this.pnlCalendario.Controls.Add(this.label4);
            this.pnlCalendario.Controls.Add(this.dtpFim);
            this.pnlCalendario.Location = new System.Drawing.Point(22, 351);
            this.pnlCalendario.Name = "pnlCalendario";
            this.pnlCalendario.Size = new System.Drawing.Size(299, 149);
            this.pnlCalendario.TabIndex = 46;
            this.pnlCalendario.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(48, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 36);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 36);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Descrição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(22, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 259);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Go.Properties.Resources.edit_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(298, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 43;
            this.toolTip1.SetToolTip(this.button1, "Clique aqui para alterar Nome e Descrição da tarefa.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCalendario);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.lblDataFinal);
            this.groupBox3.Controls.Add(this.lblQtdDias);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.groupBox3.Location = new System.Drawing.Point(22, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 128);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calendário";
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackgroundImage = global::Go.Properties.Resources.calendar_6;
            this.btnCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Location = new System.Drawing.Point(6, 26);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(49, 47);
            this.btnCalendario.TabIndex = 44;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 23.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(129, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 38);
            this.label7.TabIndex = 52;
            this.label7.Text = "Configuração da Tarefa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Go.Properties.Resources.Go_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(540, 576);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Go.Properties.Resources.cancelar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(112, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnParar
            // 
            this.btnParar.BackgroundImage = global::Go.Properties.Resources.stop;
            this.btnParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParar.FlatAppearance.BorderSize = 0;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Location = new System.Drawing.Point(531, 441);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(35, 35);
            this.btnParar.TabIndex = 27;
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackgroundImage = global::Go.Properties.Resources.pause;
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Location = new System.Drawing.Point(480, 441);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(35, 35);
            this.btnPausar.TabIndex = 26;
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImage = global::Go.Properties.Resources.play;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(424, 441);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(35, 35);
            this.btnIniciar.TabIndex = 25;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Go.Properties.Resources.garbage_1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(269, 551);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 60);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Go.Properties.Resources.Ok;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(22, 551);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 60);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // ConfigTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(632, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlCalendario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ConfigTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigTarefa";
            this.Load += new System.EventHandler(this.ConfigTarefa_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlCalendario.ResumeLayout(false);
            this.pnlCalendario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtdDias;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDarkSalmon;
        private System.Windows.Forms.Button btnSalmon;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnYellowGreen;
        private System.Windows.Forms.Button btnChartreuse;
        private System.Windows.Forms.Button btnLightGreen;
        private System.Windows.Forms.Button btnGoldrod;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnSkyBlue;
        private System.Windows.Forms.Button btnDeepSkyBlue;
        private System.Windows.Forms.Button btnDarkViolet;
        private System.Windows.Forms.Button btnOrchid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlCalendario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}