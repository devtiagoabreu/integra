namespace PromodaIntegra
{
    partial class FrmProducaoTecelagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTearNumero = new System.Windows.Forms.Label();
            this.cbxTearNumero = new System.Windows.Forms.ComboBox();
            this.lblOrdemNumero = new System.Windows.Forms.Label();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblTurnoManha = new System.Windows.Forms.Label();
            this.txtEficienciaTurnoManha = new System.Windows.Forms.TextBox();
            this.lblTurnoTarde = new System.Windows.Forms.Label();
            this.txtEficienciaTurnoTarde = new System.Windows.Forms.TextBox();
            this.lbl24hs = new System.Windows.Forms.Label();
            this.txtEficiencia24hs = new System.Windows.Forms.TextBox();
            this.lblTurnoNoite = new System.Windows.Forms.Label();
            this.txtEficienciaTurnoNoite = new System.Windows.Forms.TextBox();
            this.gbxEficienciaTurnos = new System.Windows.Forms.GroupBox();
            this.btnLimparEficiencias = new System.Windows.Forms.Button();
            this.ckbFolguistaManha = new System.Windows.Forms.CheckBox();
            this.gbxProcessoTear = new System.Windows.Forms.GroupBox();
            this.lblNumeroBatidas = new System.Windows.Forms.Label();
            this.txtNumeroBatidas = new System.Windows.Forms.TextBox();
            this.ckbTearDuplo = new System.Windows.Forms.CheckBox();
            this.cbxRoloUrdume2 = new System.Windows.Forms.ComboBox();
            this.lblRoloUrdume2 = new System.Windows.Forms.Label();
            this.cbxRoloUrdume = new System.Windows.Forms.ComboBox();
            this.lblRoloUrdume = new System.Windows.Forms.Label();
            this.cbxOrdemNumero = new System.Windows.Forms.ComboBox();
            this.cbxDesenhoNumero = new System.Windows.Forms.ComboBox();
            this.lblDesenhoNumero = new System.Windows.Forms.Label();
            this.cbxCorNumero = new System.Windows.Forms.ComboBox();
            this.lblCorNumero = new System.Windows.Forms.Label();
            this.gbxObs = new System.Windows.Forms.GroupBox();
            this.rtxObs = new System.Windows.Forms.RichTextBox();
            this.dtpDataProducao = new System.Windows.Forms.DateTimePicker();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbEficienciasMetragens = new System.Windows.Forms.GroupBox();
            this.btnExluir = new System.Windows.Forms.Button();
            this.tbcEficienciasMetragens = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEficienasMetragens = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folguista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tearNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordemNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roloUrdume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eficienciaRpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eManha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNoite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e24hs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mManha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetragemNoites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m24hs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProducao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxSituacaoTear = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStatusMotivo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxStatusTear = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCorte = new System.Windows.Forms.Label();
            this.txtCorte = new System.Windows.Forms.TextBox();
            this.lblMetragemLancadaTotalManha = new System.Windows.Forms.Label();
            this.lblMetragemLancadaTotalNoite = new System.Windows.Forms.Label();
            this.lblMetragemLancadaTotalTarde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetragemAcumulada = new System.Windows.Forms.TextBox();
            this.txtMetrosTurnoTarde = new System.Windows.Forms.TextBox();
            this.txtMetrosTurnoManha = new System.Windows.Forms.TextBox();
            this.btnMetrosInsert = new System.Windows.Forms.Button();
            this.lblMetrosInsert = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMetrosInsert = new System.Windows.Forms.TextBox();
            this.lblMetrosTurnoManha = new System.Windows.Forms.Label();
            this.txtMetros24hs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMetrosTurnoNoite = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCarregarEficiencias = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbFolguistaNoite = new System.Windows.Forms.CheckBox();
            this.ckbFolguistaTarde = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDataEficiencias = new System.Windows.Forms.DateTimePicker();
            this.txtEficienciaFolguista = new System.Windows.Forms.TextBox();
            this.lblEficienciaFolguista = new System.Windows.Forms.Label();
            this.lblMetragemFolguista = new System.Windows.Forms.Label();
            this.txtMetragemFolguista = new System.Windows.Forms.TextBox();
            this.gbxEficienciaTurnos.SuspendLayout();
            this.gbxProcessoTear.SuspendLayout();
            this.gbxObs.SuspendLayout();
            this.gpbEficienciasMetragens.SuspendLayout();
            this.tbcEficienciasMetragens.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEficienasMetragens)).BeginInit();
            this.gbxSituacaoTear.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTearNumero
            // 
            this.lblTearNumero.AutoSize = true;
            this.lblTearNumero.Location = new System.Drawing.Point(8, 24);
            this.lblTearNumero.Name = "lblTearNumero";
            this.lblTearNumero.Size = new System.Drawing.Size(59, 13);
            this.lblTearNumero.TabIndex = 0;
            this.lblTearNumero.Text = "Nº do Tear";
            // 
            // cbxTearNumero
            // 
            this.cbxTearNumero.FormattingEnabled = true;
            this.cbxTearNumero.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cbxTearNumero.Location = new System.Drawing.Point(8, 44);
            this.cbxTearNumero.Name = "cbxTearNumero";
            this.cbxTearNumero.Size = new System.Drawing.Size(185, 21);
            this.cbxTearNumero.TabIndex = 1;
            this.cbxTearNumero.SelectedIndexChanged += new System.EventHandler(this.cbxTearNumero_SelectedIndexChanged);
            this.cbxTearNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTearNumero_KeyPress);
            // 
            // lblOrdemNumero
            // 
            this.lblOrdemNumero.AutoSize = true;
            this.lblOrdemNumero.Location = new System.Drawing.Point(196, 24);
            this.lblOrdemNumero.Name = "lblOrdemNumero";
            this.lblOrdemNumero.Size = new System.Drawing.Size(112, 13);
            this.lblOrdemNumero.TabIndex = 3;
            this.lblOrdemNumero.Text = "Ordem/Artigo/Produto";
            // 
            // txtRPM
            // 
            this.txtRPM.Location = new System.Drawing.Point(89, 44);
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.Size = new System.Drawing.Size(61, 20);
            this.txtRPM.TabIndex = 2;
            this.txtRPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRPM_KeyPress);
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(86, 23);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(31, 13);
            this.lblRPM.TabIndex = 1;
            this.lblRPM.Text = "RPM";
            // 
            // lblTurnoManha
            // 
            this.lblTurnoManha.AutoSize = true;
            this.lblTurnoManha.Location = new System.Drawing.Point(153, 23);
            this.lblTurnoManha.Name = "lblTurnoManha";
            this.lblTurnoManha.Size = new System.Drawing.Size(40, 13);
            this.lblTurnoManha.TabIndex = 3;
            this.lblTurnoManha.Text = "Manhã";
            // 
            // txtEficienciaTurnoManha
            // 
            this.txtEficienciaTurnoManha.Location = new System.Drawing.Point(156, 44);
            this.txtEficienciaTurnoManha.Name = "txtEficienciaTurnoManha";
            this.txtEficienciaTurnoManha.Size = new System.Drawing.Size(69, 20);
            this.txtEficienciaTurnoManha.TabIndex = 4;
            this.txtEficienciaTurnoManha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEficienciaTurnoManha_KeyPress);
            // 
            // lblTurnoTarde
            // 
            this.lblTurnoTarde.AutoSize = true;
            this.lblTurnoTarde.Location = new System.Drawing.Point(228, 24);
            this.lblTurnoTarde.Name = "lblTurnoTarde";
            this.lblTurnoTarde.Size = new System.Drawing.Size(35, 13);
            this.lblTurnoTarde.TabIndex = 5;
            this.lblTurnoTarde.Text = "Tarde";
            // 
            // txtEficienciaTurnoTarde
            // 
            this.txtEficienciaTurnoTarde.Location = new System.Drawing.Point(231, 44);
            this.txtEficienciaTurnoTarde.Name = "txtEficienciaTurnoTarde";
            this.txtEficienciaTurnoTarde.Size = new System.Drawing.Size(69, 20);
            this.txtEficienciaTurnoTarde.TabIndex = 6;
            this.txtEficienciaTurnoTarde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEficienciaTurnoTarde_KeyPress);
            // 
            // lbl24hs
            // 
            this.lbl24hs.AutoSize = true;
            this.lbl24hs.Location = new System.Drawing.Point(374, 23);
            this.lbl24hs.Name = "lbl24hs";
            this.lbl24hs.Size = new System.Drawing.Size(35, 13);
            this.lbl24hs.TabIndex = 9;
            this.lbl24hs.Text = "24 Hs";
            // 
            // txtEficiencia24hs
            // 
            this.txtEficiencia24hs.Location = new System.Drawing.Point(377, 44);
            this.txtEficiencia24hs.Name = "txtEficiencia24hs";
            this.txtEficiencia24hs.ReadOnly = true;
            this.txtEficiencia24hs.Size = new System.Drawing.Size(84, 20);
            this.txtEficiencia24hs.TabIndex = 10;
            this.txtEficiencia24hs.TabStop = false;
            this.txtEficiencia24hs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEficiencia24hs_KeyPress);
            // 
            // lblTurnoNoite
            // 
            this.lblTurnoNoite.AutoSize = true;
            this.lblTurnoNoite.Location = new System.Drawing.Point(303, 24);
            this.lblTurnoNoite.Name = "lblTurnoNoite";
            this.lblTurnoNoite.Size = new System.Drawing.Size(32, 13);
            this.lblTurnoNoite.TabIndex = 7;
            this.lblTurnoNoite.Text = "Noite";
            // 
            // txtEficienciaTurnoNoite
            // 
            this.txtEficienciaTurnoNoite.Location = new System.Drawing.Point(306, 44);
            this.txtEficienciaTurnoNoite.Name = "txtEficienciaTurnoNoite";
            this.txtEficienciaTurnoNoite.Size = new System.Drawing.Size(69, 20);
            this.txtEficienciaTurnoNoite.TabIndex = 8;
            this.txtEficienciaTurnoNoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEficienciaTurnoNoite_KeyPress);
            // 
            // gbxEficienciaTurnos
            // 
            this.gbxEficienciaTurnos.Controls.Add(this.btnLimparEficiencias);
            this.gbxEficienciaTurnos.Controls.Add(this.txtEficienciaTurnoManha);
            this.gbxEficienciaTurnos.Controls.Add(this.lblRPM);
            this.gbxEficienciaTurnos.Controls.Add(this.lbl24hs);
            this.gbxEficienciaTurnos.Controls.Add(this.txtRPM);
            this.gbxEficienciaTurnos.Controls.Add(this.lblTurnoManha);
            this.gbxEficienciaTurnos.Controls.Add(this.txtEficiencia24hs);
            this.gbxEficienciaTurnos.Controls.Add(this.txtEficienciaTurnoTarde);
            this.gbxEficienciaTurnos.Controls.Add(this.lblTurnoNoite);
            this.gbxEficienciaTurnos.Controls.Add(this.lblTurnoTarde);
            this.gbxEficienciaTurnos.Controls.Add(this.txtEficienciaTurnoNoite);
            this.gbxEficienciaTurnos.Location = new System.Drawing.Point(6, 103);
            this.gbxEficienciaTurnos.Name = "gbxEficienciaTurnos";
            this.gbxEficienciaTurnos.Size = new System.Drawing.Size(474, 105);
            this.gbxEficienciaTurnos.TabIndex = 5;
            this.gbxEficienciaTurnos.TabStop = false;
            this.gbxEficienciaTurnos.Text = "Eficiência dos Turnos em %";
            // 
            // btnLimparEficiencias
            // 
            this.btnLimparEficiencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEficiencias.Location = new System.Drawing.Point(6, 43);
            this.btnLimparEficiencias.Name = "btnLimparEficiencias";
            this.btnLimparEficiencias.Size = new System.Drawing.Size(77, 21);
            this.btnLimparEficiencias.TabIndex = 0;
            this.btnLimparEficiencias.TabStop = false;
            this.btnLimparEficiencias.Text = "Limpar";
            this.btnLimparEficiencias.UseVisualStyleBackColor = true;
            this.btnLimparEficiencias.Click += new System.EventHandler(this.btnLimparEficiencias_Click);
            // 
            // ckbFolguistaManha
            // 
            this.ckbFolguistaManha.AutoSize = true;
            this.ckbFolguistaManha.Location = new System.Drawing.Point(9, 24);
            this.ckbFolguistaManha.Name = "ckbFolguistaManha";
            this.ckbFolguistaManha.Size = new System.Drawing.Size(59, 17);
            this.ckbFolguistaManha.TabIndex = 0;
            this.ckbFolguistaManha.Text = "Manhã";
            this.ckbFolguistaManha.UseVisualStyleBackColor = true;
            this.ckbFolguistaManha.CheckedChanged += new System.EventHandler(this.ckbFolguistaManha_CheckedChanged);
            this.ckbFolguistaManha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbFolguistaManha_KeyPress);
            // 
            // gbxProcessoTear
            // 
            this.gbxProcessoTear.Controls.Add(this.lblNumeroBatidas);
            this.gbxProcessoTear.Controls.Add(this.txtNumeroBatidas);
            this.gbxProcessoTear.Controls.Add(this.ckbTearDuplo);
            this.gbxProcessoTear.Controls.Add(this.cbxRoloUrdume2);
            this.gbxProcessoTear.Controls.Add(this.lblRoloUrdume2);
            this.gbxProcessoTear.Controls.Add(this.cbxRoloUrdume);
            this.gbxProcessoTear.Controls.Add(this.lblRoloUrdume);
            this.gbxProcessoTear.Controls.Add(this.cbxOrdemNumero);
            this.gbxProcessoTear.Controls.Add(this.lblOrdemNumero);
            this.gbxProcessoTear.Controls.Add(this.cbxTearNumero);
            this.gbxProcessoTear.Controls.Add(this.lblTearNumero);
            this.gbxProcessoTear.Location = new System.Drawing.Point(6, 17);
            this.gbxProcessoTear.Name = "gbxProcessoTear";
            this.gbxProcessoTear.Size = new System.Drawing.Size(574, 80);
            this.gbxProcessoTear.TabIndex = 2;
            this.gbxProcessoTear.TabStop = false;
            this.gbxProcessoTear.Text = "Processo Tear";
            // 
            // lblNumeroBatidas
            // 
            this.lblNumeroBatidas.AutoSize = true;
            this.lblNumeroBatidas.Location = new System.Drawing.Point(311, 25);
            this.lblNumeroBatidas.Name = "lblNumeroBatidas";
            this.lblNumeroBatidas.Size = new System.Drawing.Size(57, 13);
            this.lblNumeroBatidas.TabIndex = 5;
            this.lblNumeroBatidas.Text = "Nº Batidas";
            // 
            // txtNumeroBatidas
            // 
            this.txtNumeroBatidas.Location = new System.Drawing.Point(314, 44);
            this.txtNumeroBatidas.Name = "txtNumeroBatidas";
            this.txtNumeroBatidas.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroBatidas.TabIndex = 6;
            this.txtNumeroBatidas.TabStop = false;
            this.txtNumeroBatidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroBatidas_KeyPress);
            // 
            // ckbTearDuplo
            // 
            this.ckbTearDuplo.AutoSize = true;
            this.ckbTearDuplo.Location = new System.Drawing.Point(74, 24);
            this.ckbTearDuplo.Name = "ckbTearDuplo";
            this.ckbTearDuplo.Size = new System.Drawing.Size(54, 17);
            this.ckbTearDuplo.TabIndex = 2;
            this.ckbTearDuplo.Text = "Duplo";
            this.ckbTearDuplo.UseVisualStyleBackColor = true;
            this.ckbTearDuplo.CheckedChanged += new System.EventHandler(this.ckbTearDuplo_CheckedChanged);
            this.ckbTearDuplo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbTearDuplo_KeyPress);
            // 
            // cbxRoloUrdume2
            // 
            this.cbxRoloUrdume2.Enabled = false;
            this.cbxRoloUrdume2.FormattingEnabled = true;
            this.cbxRoloUrdume2.Location = new System.Drawing.Point(480, 44);
            this.cbxRoloUrdume2.Name = "cbxRoloUrdume2";
            this.cbxRoloUrdume2.Size = new System.Drawing.Size(88, 21);
            this.cbxRoloUrdume2.TabIndex = 10;
            this.cbxRoloUrdume2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxRoloUrdume2_KeyPress);
            // 
            // lblRoloUrdume2
            // 
            this.lblRoloUrdume2.AutoSize = true;
            this.lblRoloUrdume2.Location = new System.Drawing.Point(477, 25);
            this.lblRoloUrdume2.Name = "lblRoloUrdume2";
            this.lblRoloUrdume2.Size = new System.Drawing.Size(77, 13);
            this.lblRoloUrdume2.TabIndex = 9;
            this.lblRoloUrdume2.Text = "2º  R. Urdume ";
            // 
            // cbxRoloUrdume
            // 
            this.cbxRoloUrdume.FormattingEnabled = true;
            this.cbxRoloUrdume.Location = new System.Drawing.Point(380, 44);
            this.cbxRoloUrdume.Name = "cbxRoloUrdume";
            this.cbxRoloUrdume.Size = new System.Drawing.Size(94, 21);
            this.cbxRoloUrdume.TabIndex = 8;
            this.cbxRoloUrdume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxRoloUrdume_KeyPress);
            // 
            // lblRoloUrdume
            // 
            this.lblRoloUrdume.AutoSize = true;
            this.lblRoloUrdume.Location = new System.Drawing.Point(377, 25);
            this.lblRoloUrdume.Name = "lblRoloUrdume";
            this.lblRoloUrdume.Size = new System.Drawing.Size(84, 13);
            this.lblRoloUrdume.TabIndex = 7;
            this.lblRoloUrdume.Text = "Rolo de Urdume";
            // 
            // cbxOrdemNumero
            // 
            this.cbxOrdemNumero.FormattingEnabled = true;
            this.cbxOrdemNumero.Location = new System.Drawing.Point(199, 44);
            this.cbxOrdemNumero.Name = "cbxOrdemNumero";
            this.cbxOrdemNumero.Size = new System.Drawing.Size(109, 21);
            this.cbxOrdemNumero.TabIndex = 4;
            this.cbxOrdemNumero.SelectedValueChanged += new System.EventHandler(this.cbxOrdemNumero_SelectedValueChanged);
            this.cbxOrdemNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxOrdemNumero_KeyPress);
            // 
            // cbxDesenhoNumero
            // 
            this.cbxDesenhoNumero.FormattingEnabled = true;
            this.cbxDesenhoNumero.Location = new System.Drawing.Point(697, 218);
            this.cbxDesenhoNumero.Name = "cbxDesenhoNumero";
            this.cbxDesenhoNumero.Size = new System.Drawing.Size(106, 21);
            this.cbxDesenhoNumero.TabIndex = 14;
            this.cbxDesenhoNumero.Visible = false;
            // 
            // lblDesenhoNumero
            // 
            this.lblDesenhoNumero.AutoSize = true;
            this.lblDesenhoNumero.Location = new System.Drawing.Point(697, 233);
            this.lblDesenhoNumero.Name = "lblDesenhoNumero";
            this.lblDesenhoNumero.Size = new System.Drawing.Size(50, 13);
            this.lblDesenhoNumero.TabIndex = 16;
            this.lblDesenhoNumero.Text = "Desenho";
            this.lblDesenhoNumero.Visible = false;
            // 
            // cbxCorNumero
            // 
            this.cbxCorNumero.FormattingEnabled = true;
            this.cbxCorNumero.Location = new System.Drawing.Point(679, 218);
            this.cbxCorNumero.Name = "cbxCorNumero";
            this.cbxCorNumero.Size = new System.Drawing.Size(16, 21);
            this.cbxCorNumero.TabIndex = 13;
            this.cbxCorNumero.Visible = false;
            // 
            // lblCorNumero
            // 
            this.lblCorNumero.AutoSize = true;
            this.lblCorNumero.Location = new System.Drawing.Point(676, 237);
            this.lblCorNumero.Name = "lblCorNumero";
            this.lblCorNumero.Size = new System.Drawing.Size(23, 13);
            this.lblCorNumero.TabIndex = 15;
            this.lblCorNumero.Text = "Cor";
            this.lblCorNumero.Visible = false;
            // 
            // gbxObs
            // 
            this.gbxObs.Controls.Add(this.rtxObs);
            this.gbxObs.Location = new System.Drawing.Point(876, 17);
            this.gbxObs.Name = "gbxObs";
            this.gbxObs.Size = new System.Drawing.Size(234, 80);
            this.gbxObs.TabIndex = 4;
            this.gbxObs.TabStop = false;
            this.gbxObs.Text = "Obs";
            // 
            // rtxObs
            // 
            this.rtxObs.Location = new System.Drawing.Point(6, 21);
            this.rtxObs.Name = "rtxObs";
            this.rtxObs.Size = new System.Drawing.Size(222, 46);
            this.rtxObs.TabIndex = 0;
            this.rtxObs.Text = "";
            this.rtxObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxObs_KeyPress);
            // 
            // dtpDataProducao
            // 
            this.dtpDataProducao.Location = new System.Drawing.Point(6, 24);
            this.dtpDataProducao.Name = "dtpDataProducao";
            this.dtpDataProducao.Size = new System.Drawing.Size(250, 20);
            this.dtpDataProducao.TabIndex = 0;
            this.dtpDataProducao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDataProducao_KeyPress);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(486, 226);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(90, 38);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gpbEficienciasMetragens
            // 
            this.gpbEficienciasMetragens.Controls.Add(this.btnExluir);
            this.gpbEficienciasMetragens.Controls.Add(this.tbcEficienciasMetragens);
            this.gpbEficienciasMetragens.Location = new System.Drawing.Point(6, 272);
            this.gpbEficienciasMetragens.Name = "gpbEficienciasMetragens";
            this.gpbEficienciasMetragens.Size = new System.Drawing.Size(1104, 259);
            this.gpbEficienciasMetragens.TabIndex = 20;
            this.gpbEficienciasMetragens.TabStop = false;
            this.gpbEficienciasMetragens.Text = "Eficiências | Metragem ";
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(1047, 41);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(48, 38);
            this.btnExluir.TabIndex = 1;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // tbcEficienciasMetragens
            // 
            this.tbcEficienciasMetragens.Controls.Add(this.tabPage1);
            this.tbcEficienciasMetragens.Controls.Add(this.tabPage2);
            this.tbcEficienciasMetragens.Location = new System.Drawing.Point(9, 30);
            this.tbcEficienciasMetragens.Name = "tbcEficienciasMetragens";
            this.tbcEficienciasMetragens.SelectedIndex = 0;
            this.tbcEficienciasMetragens.Size = new System.Drawing.Size(1040, 235);
            this.tbcEficienciasMetragens.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEficienasMetragens);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produção";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEficienasMetragens
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEficienasMetragens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEficienasMetragens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEficienasMetragens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Folguista,
            this.Operador,
            this.tearNumero,
            this.ordemNumero,
            this.roloUrdume,
            this.rolo2,
            this.situacao,
            this.motivoSituacao,
            this.OBS,
            this.eficienciaRpm,
            this.eManha,
            this.eTarde,
            this.eNoite,
            this.e24hs,
            this.mManha,
            this.mTarde,
            this.MetragemNoites,
            this.m24hs,
            this.mAcumulada,
            this.dataCadastro,
            this.dataProducao,
            this.ativo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEficienasMetragens.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEficienasMetragens.Location = new System.Drawing.Point(6, 6);
            this.dgvEficienasMetragens.Name = "dgvEficienasMetragens";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEficienasMetragens.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEficienasMetragens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEficienasMetragens.Size = new System.Drawing.Size(1012, 195);
            this.dgvEficienasMetragens.TabIndex = 0;
            this.dgvEficienasMetragens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEficienasMetragens_CellContentClick);
            this.dgvEficienasMetragens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEficienasMetragens_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Folguista
            // 
            this.Folguista.DataPropertyName = "Folguista";
            this.Folguista.HeaderText = "Folguista";
            this.Folguista.Name = "Folguista";
            this.Folguista.Visible = false;
            // 
            // Operador
            // 
            this.Operador.DataPropertyName = "OperadorNumero";
            this.Operador.HeaderText = "Operador";
            this.Operador.Name = "Operador";
            this.Operador.Visible = false;
            // 
            // tearNumero
            // 
            this.tearNumero.DataPropertyName = "TearNumero";
            this.tearNumero.HeaderText = "Tear";
            this.tearNumero.Name = "tearNumero";
            this.tearNumero.Width = 50;
            // 
            // ordemNumero
            // 
            this.ordemNumero.DataPropertyName = "OrdemNumero";
            this.ordemNumero.HeaderText = "Ordem";
            this.ordemNumero.Name = "ordemNumero";
            this.ordemNumero.Width = 70;
            // 
            // roloUrdume
            // 
            this.roloUrdume.DataPropertyName = "RoloUrdume";
            this.roloUrdume.HeaderText = "Rolo";
            this.roloUrdume.Name = "roloUrdume";
            this.roloUrdume.Width = 70;
            // 
            // rolo2
            // 
            this.rolo2.DataPropertyName = "RoloUrdume2";
            this.rolo2.HeaderText = "Rolo 2";
            this.rolo2.Name = "rolo2";
            this.rolo2.Width = 70;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "Situacao";
            this.situacao.HeaderText = "situacao";
            this.situacao.Name = "situacao";
            this.situacao.Visible = false;
            // 
            // motivoSituacao
            // 
            this.motivoSituacao.DataPropertyName = "MotivoSituacao";
            this.motivoSituacao.HeaderText = "motivoSituacao";
            this.motivoSituacao.Name = "motivoSituacao";
            this.motivoSituacao.Visible = false;
            // 
            // OBS
            // 
            this.OBS.DataPropertyName = "Obs";
            this.OBS.HeaderText = "OBS";
            this.OBS.Name = "OBS";
            this.OBS.Visible = false;
            // 
            // eficienciaRpm
            // 
            this.eficienciaRpm.DataPropertyName = "RPM";
            this.eficienciaRpm.HeaderText = "RPM";
            this.eficienciaRpm.Name = "eficienciaRpm";
            this.eficienciaRpm.Width = 50;
            // 
            // eManha
            // 
            this.eManha.DataPropertyName = "EficienciaManha";
            this.eManha.HeaderText = "E.Manhã";
            this.eManha.Name = "eManha";
            this.eManha.Width = 53;
            // 
            // eTarde
            // 
            this.eTarde.DataPropertyName = "EficienciaTarde";
            this.eTarde.HeaderText = "E.Tarde";
            this.eTarde.Name = "eTarde";
            this.eTarde.Width = 52;
            // 
            // eNoite
            // 
            this.eNoite.DataPropertyName = "EficienciaNoite";
            this.eNoite.HeaderText = "E. Noite";
            this.eNoite.Name = "eNoite";
            this.eNoite.Width = 52;
            // 
            // e24hs
            // 
            this.e24hs.DataPropertyName = "Eficiencia24hs";
            this.e24hs.HeaderText = "E.24 hs";
            this.e24hs.Name = "e24hs";
            this.e24hs.Width = 52;
            // 
            // mManha
            // 
            this.mManha.DataPropertyName = "MetragemManha";
            this.mManha.HeaderText = "Mts Manhã";
            this.mManha.Name = "mManha";
            this.mManha.Width = 85;
            // 
            // mTarde
            // 
            this.mTarde.DataPropertyName = "MetragemTarde";
            this.mTarde.HeaderText = "Mts Tarde";
            this.mTarde.Name = "mTarde";
            this.mTarde.Width = 85;
            // 
            // MetragemNoites
            // 
            this.MetragemNoites.DataPropertyName = "MetragemNoite";
            this.MetragemNoites.HeaderText = "Mts Noite";
            this.MetragemNoites.Name = "MetragemNoites";
            this.MetragemNoites.Width = 85;
            // 
            // m24hs
            // 
            this.m24hs.DataPropertyName = "Metragem24hs";
            this.m24hs.HeaderText = "Mts 24 hs";
            this.m24hs.Name = "m24hs";
            this.m24hs.Width = 85;
            // 
            // mAcumulada
            // 
            this.mAcumulada.DataPropertyName = "MetragemAcumulada";
            this.mAcumulada.HeaderText = "Mts Total";
            this.mAcumulada.Name = "mAcumulada";
            this.mAcumulada.Width = 90;
            // 
            // dataCadastro
            // 
            this.dataCadastro.DataPropertyName = "DataCadastro";
            this.dataCadastro.HeaderText = "dataCadastro";
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.Visible = false;
            // 
            // dataProducao
            // 
            this.dataProducao.DataPropertyName = "DataProducao";
            this.dataProducao.HeaderText = "Data";
            this.dataProducao.Name = "dataProducao";
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "Ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1032, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eficiência";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbxSituacaoTear
            // 
            this.gbxSituacaoTear.Controls.Add(this.label1);
            this.gbxSituacaoTear.Controls.Add(this.cbxStatusMotivo);
            this.gbxSituacaoTear.Controls.Add(this.label13);
            this.gbxSituacaoTear.Controls.Add(this.cbxStatusTear);
            this.gbxSituacaoTear.Location = new System.Drawing.Point(586, 17);
            this.gbxSituacaoTear.Name = "gbxSituacaoTear";
            this.gbxSituacaoTear.Size = new System.Drawing.Size(284, 80);
            this.gbxSituacaoTear.TabIndex = 3;
            this.gbxSituacaoTear.TabStop = false;
            this.gbxSituacaoTear.Text = "Situação Tear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivo";
            // 
            // cbxStatusMotivo
            // 
            this.cbxStatusMotivo.Enabled = false;
            this.cbxStatusMotivo.FormattingEnabled = true;
            this.cbxStatusMotivo.Items.AddRange(new object[] {
            "Manutenção no Tear",
            "Mecânica do Tear",
            "Aguardando peças",
            "Manutenção rede Elétrica",
            "Falta de Energia",
            "Fim de Rolo",
            "Fim de Trama",
            "Peça não zerada",
            "Troca de Artigo",
            "Defeito no Tecido"});
            this.cbxStatusMotivo.Location = new System.Drawing.Point(115, 43);
            this.cbxStatusMotivo.Name = "cbxStatusMotivo";
            this.cbxStatusMotivo.Size = new System.Drawing.Size(163, 21);
            this.cbxStatusMotivo.TabIndex = 3;
            this.cbxStatusMotivo.Text = "Manutenção no Tear";
            this.cbxStatusMotivo.SelectedIndexChanged += new System.EventHandler(this.cbxStatusMotivo_SelectedIndexChanged);
            this.cbxStatusMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxStatusMotivo_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Status";
            // 
            // cbxStatusTear
            // 
            this.cbxStatusTear.FormattingEnabled = true;
            this.cbxStatusTear.Items.AddRange(new object[] {
            "Trabalhando",
            "Parado"});
            this.cbxStatusTear.Location = new System.Drawing.Point(4, 43);
            this.cbxStatusTear.Name = "cbxStatusTear";
            this.cbxStatusTear.Size = new System.Drawing.Size(105, 21);
            this.cbxStatusTear.TabIndex = 1;
            this.cbxStatusTear.Text = "Trabalhando";
            this.cbxStatusTear.SelectedIndexChanged += new System.EventHandler(this.cbxStatusTear_SelectedIndexChanged);
            this.cbxStatusTear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxStatusTear_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCorte);
            this.groupBox6.Controls.Add(this.txtCorte);
            this.groupBox6.Controls.Add(this.lblMetragemLancadaTotalManha);
            this.groupBox6.Controls.Add(this.lblMetragemLancadaTotalNoite);
            this.groupBox6.Controls.Add(this.lblMetragemLancadaTotalTarde);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtMetragemAcumulada);
            this.groupBox6.Controls.Add(this.txtMetrosTurnoTarde);
            this.groupBox6.Controls.Add(this.txtMetrosTurnoManha);
            this.groupBox6.Controls.Add(this.btnMetrosInsert);
            this.groupBox6.Controls.Add(this.lblMetrosInsert);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txtMetrosInsert);
            this.groupBox6.Controls.Add(this.lblMetrosTurnoManha);
            this.groupBox6.Controls.Add(this.txtMetros24hs);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtMetrosTurnoNoite);
            this.groupBox6.Location = new System.Drawing.Point(486, 103);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(624, 105);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Metragem - Turnos";
            // 
            // lblCorte
            // 
            this.lblCorte.AutoSize = true;
            this.lblCorte.Location = new System.Drawing.Point(554, 24);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(32, 13);
            this.lblCorte.TabIndex = 16;
            this.lblCorte.Text = "Corte";
            // 
            // txtCorte
            // 
            this.txtCorte.Location = new System.Drawing.Point(557, 45);
            this.txtCorte.Name = "txtCorte";
            this.txtCorte.Size = new System.Drawing.Size(61, 20);
            this.txtCorte.TabIndex = 17;
            this.txtCorte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorte_KeyPress);
            // 
            // lblMetragemLancadaTotalManha
            // 
            this.lblMetragemLancadaTotalManha.AutoSize = true;
            this.lblMetragemLancadaTotalManha.Location = new System.Drawing.Point(164, 67);
            this.lblMetragemLancadaTotalManha.Name = "lblMetragemLancadaTotalManha";
            this.lblMetragemLancadaTotalManha.Size = new System.Drawing.Size(13, 13);
            this.lblMetragemLancadaTotalManha.TabIndex = 5;
            this.lblMetragemLancadaTotalManha.Text = "0";
            // 
            // lblMetragemLancadaTotalNoite
            // 
            this.lblMetragemLancadaTotalNoite.AutoSize = true;
            this.lblMetragemLancadaTotalNoite.Location = new System.Drawing.Point(320, 66);
            this.lblMetragemLancadaTotalNoite.Name = "lblMetragemLancadaTotalNoite";
            this.lblMetragemLancadaTotalNoite.Size = new System.Drawing.Size(13, 13);
            this.lblMetragemLancadaTotalNoite.TabIndex = 11;
            this.lblMetragemLancadaTotalNoite.Text = "0";
            // 
            // lblMetragemLancadaTotalTarde
            // 
            this.lblMetragemLancadaTotalTarde.AutoSize = true;
            this.lblMetragemLancadaTotalTarde.Location = new System.Drawing.Point(241, 66);
            this.lblMetragemLancadaTotalTarde.Name = "lblMetragemLancadaTotalTarde";
            this.lblMetragemLancadaTotalTarde.Size = new System.Drawing.Size(13, 13);
            this.lblMetragemLancadaTotalTarde.TabIndex = 8;
            this.lblMetragemLancadaTotalTarde.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "M.Acumulada";
            // 
            // txtMetragemAcumulada
            // 
            this.txtMetragemAcumulada.Location = new System.Drawing.Point(477, 45);
            this.txtMetragemAcumulada.Name = "txtMetragemAcumulada";
            this.txtMetragemAcumulada.ReadOnly = true;
            this.txtMetragemAcumulada.Size = new System.Drawing.Size(74, 20);
            this.txtMetragemAcumulada.TabIndex = 15;
            this.txtMetragemAcumulada.TabStop = false;
            // 
            // txtMetrosTurnoTarde
            // 
            this.txtMetrosTurnoTarde.Location = new System.Drawing.Point(244, 44);
            this.txtMetrosTurnoTarde.Name = "txtMetrosTurnoTarde";
            this.txtMetrosTurnoTarde.ReadOnly = true;
            this.txtMetrosTurnoTarde.Size = new System.Drawing.Size(73, 20);
            this.txtMetrosTurnoTarde.TabIndex = 7;
            this.txtMetrosTurnoTarde.TabStop = false;
            this.txtMetrosTurnoTarde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetrosTurnoTarde_KeyPress);
            // 
            // txtMetrosTurnoManha
            // 
            this.txtMetrosTurnoManha.Location = new System.Drawing.Point(167, 45);
            this.txtMetrosTurnoManha.Name = "txtMetrosTurnoManha";
            this.txtMetrosTurnoManha.ReadOnly = true;
            this.txtMetrosTurnoManha.Size = new System.Drawing.Size(71, 20);
            this.txtMetrosTurnoManha.TabIndex = 4;
            this.txtMetrosTurnoManha.TabStop = false;
            this.txtMetrosTurnoManha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetrosTurnoManha_KeyPress);
            // 
            // btnMetrosInsert
            // 
            this.btnMetrosInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetrosInsert.Location = new System.Drawing.Point(6, 44);
            this.btnMetrosInsert.Name = "btnMetrosInsert";
            this.btnMetrosInsert.Size = new System.Drawing.Size(66, 21);
            this.btnMetrosInsert.TabIndex = 0;
            this.btnMetrosInsert.TabStop = false;
            this.btnMetrosInsert.Text = "Limpar";
            this.btnMetrosInsert.UseVisualStyleBackColor = true;
            this.btnMetrosInsert.Click += new System.EventHandler(this.btnMetrosInsert_Click);
            this.btnMetrosInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMetrosInsert_KeyPress);
            // 
            // lblMetrosInsert
            // 
            this.lblMetrosInsert.AutoSize = true;
            this.lblMetrosInsert.Location = new System.Drawing.Point(75, 24);
            this.lblMetrosInsert.Name = "lblMetrosInsert";
            this.lblMetrosInsert.Size = new System.Drawing.Size(39, 13);
            this.lblMetrosInsert.TabIndex = 1;
            this.lblMetrosInsert.Text = "Metros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "24 Hs";
            // 
            // txtMetrosInsert
            // 
            this.txtMetrosInsert.Location = new System.Drawing.Point(78, 44);
            this.txtMetrosInsert.Name = "txtMetrosInsert";
            this.txtMetrosInsert.Size = new System.Drawing.Size(83, 20);
            this.txtMetrosInsert.TabIndex = 2;
            this.txtMetrosInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetrosInsert_KeyPress);
            // 
            // lblMetrosTurnoManha
            // 
            this.lblMetrosTurnoManha.AutoSize = true;
            this.lblMetrosTurnoManha.Location = new System.Drawing.Point(170, 23);
            this.lblMetrosTurnoManha.Name = "lblMetrosTurnoManha";
            this.lblMetrosTurnoManha.Size = new System.Drawing.Size(40, 13);
            this.lblMetrosTurnoManha.TabIndex = 3;
            this.lblMetrosTurnoManha.Text = "Manhã";
            // 
            // txtMetros24hs
            // 
            this.txtMetros24hs.Location = new System.Drawing.Point(399, 45);
            this.txtMetros24hs.Name = "txtMetros24hs";
            this.txtMetros24hs.ReadOnly = true;
            this.txtMetros24hs.Size = new System.Drawing.Size(72, 20);
            this.txtMetros24hs.TabIndex = 13;
            this.txtMetros24hs.TabStop = false;
            this.txtMetros24hs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetros24hs_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Noite";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Tarde";
            // 
            // txtMetrosTurnoNoite
            // 
            this.txtMetrosTurnoNoite.Location = new System.Drawing.Point(323, 45);
            this.txtMetrosTurnoNoite.Name = "txtMetrosTurnoNoite";
            this.txtMetrosTurnoNoite.ReadOnly = true;
            this.txtMetrosTurnoNoite.Size = new System.Drawing.Size(70, 20);
            this.txtMetrosTurnoNoite.TabIndex = 10;
            this.txtMetrosTurnoNoite.TabStop = false;
            this.txtMetrosTurnoNoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetrosTurnoNoite_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtpDataProducao);
            this.groupBox7.Location = new System.Drawing.Point(211, 214);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(269, 54);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data da produção";
            // 
            // btnCarregarEficiencias
            // 
            this.btnCarregarEficiencias.Location = new System.Drawing.Point(1023, 226);
            this.btnCarregarEficiencias.Name = "btnCarregarEficiencias";
            this.btnCarregarEficiencias.Size = new System.Drawing.Size(87, 38);
            this.btnCarregarEficiencias.TabIndex = 19;
            this.btnCarregarEficiencias.Text = "Carregar Eficiências";
            this.btnCarregarEficiencias.UseVisualStyleBackColor = true;
            this.btnCarregarEficiencias.Click += new System.EventHandler(this.btnCarregarEficiencias_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 1);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(38, 1);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(51, 13);
            this.lblOperador.TabIndex = 1;
            this.lblOperador.Text = "Operador";
            this.lblOperador.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbFolguistaNoite);
            this.groupBox1.Controls.Add(this.ckbFolguistaTarde);
            this.groupBox1.Controls.Add(this.ckbFolguistaManha);
            this.groupBox1.Location = new System.Drawing.Point(6, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno Folguista";
            // 
            // ckbFolguistaNoite
            // 
            this.ckbFolguistaNoite.AutoSize = true;
            this.ckbFolguistaNoite.Location = new System.Drawing.Point(134, 24);
            this.ckbFolguistaNoite.Name = "ckbFolguistaNoite";
            this.ckbFolguistaNoite.Size = new System.Drawing.Size(51, 17);
            this.ckbFolguistaNoite.TabIndex = 2;
            this.ckbFolguistaNoite.Text = "Noite";
            this.ckbFolguistaNoite.UseVisualStyleBackColor = true;
            this.ckbFolguistaNoite.CheckedChanged += new System.EventHandler(this.ckbFolguistaNoite_CheckedChanged);
            this.ckbFolguistaNoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbFolguistaNoite_KeyPress);
            // 
            // ckbFolguistaTarde
            // 
            this.ckbFolguistaTarde.AutoSize = true;
            this.ckbFolguistaTarde.Location = new System.Drawing.Point(74, 24);
            this.ckbFolguistaTarde.Name = "ckbFolguistaTarde";
            this.ckbFolguistaTarde.Size = new System.Drawing.Size(54, 17);
            this.ckbFolguistaTarde.TabIndex = 1;
            this.ckbFolguistaTarde.Text = "Tarde";
            this.ckbFolguistaTarde.UseVisualStyleBackColor = true;
            this.ckbFolguistaTarde.CheckedChanged += new System.EventHandler(this.ckbFolguistaTarde_CheckedChanged);
            this.ckbFolguistaTarde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbFolguistaTarde_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDataEficiencias);
            this.groupBox2.Location = new System.Drawing.Point(653, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data das  Eficiências";
            // 
            // dtpDataEficiencias
            // 
            this.dtpDataEficiencias.Location = new System.Drawing.Point(6, 19);
            this.dtpDataEficiencias.Name = "dtpDataEficiencias";
            this.dtpDataEficiencias.Size = new System.Drawing.Size(263, 20);
            this.dtpDataEficiencias.TabIndex = 0;
            // 
            // txtEficienciaFolguista
            // 
            this.txtEficienciaFolguista.Location = new System.Drawing.Point(578, 238);
            this.txtEficienciaFolguista.Name = "txtEficienciaFolguista";
            this.txtEficienciaFolguista.Size = new System.Drawing.Size(69, 20);
            this.txtEficienciaFolguista.TabIndex = 11;
            this.txtEficienciaFolguista.Visible = false;
            // 
            // lblEficienciaFolguista
            // 
            this.lblEficienciaFolguista.AutoSize = true;
            this.lblEficienciaFolguista.Location = new System.Drawing.Point(575, 222);
            this.lblEficienciaFolguista.Name = "lblEficienciaFolguista";
            this.lblEficienciaFolguista.Size = new System.Drawing.Size(49, 13);
            this.lblEficienciaFolguista.TabIndex = 10;
            this.lblEficienciaFolguista.Text = "Folguista";
            this.lblEficienciaFolguista.Visible = false;
            // 
            // lblMetragemFolguista
            // 
            this.lblMetragemFolguista.AutoSize = true;
            this.lblMetragemFolguista.Location = new System.Drawing.Point(942, 215);
            this.lblMetragemFolguista.Name = "lblMetragemFolguista";
            this.lblMetragemFolguista.Size = new System.Drawing.Size(49, 13);
            this.lblMetragemFolguista.TabIndex = 17;
            this.lblMetragemFolguista.Text = "Folguista";
            this.lblMetragemFolguista.Visible = false;
            // 
            // txtMetragemFolguista
            // 
            this.txtMetragemFolguista.Location = new System.Drawing.Point(945, 235);
            this.txtMetragemFolguista.Name = "txtMetragemFolguista";
            this.txtMetragemFolguista.ReadOnly = true;
            this.txtMetragemFolguista.Size = new System.Drawing.Size(75, 20);
            this.txtMetragemFolguista.TabIndex = 18;
            this.txtMetragemFolguista.TabStop = false;
            this.txtMetragemFolguista.Visible = false;
            // 
            // FrmCrudProducaoTecelagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 549);
            this.Controls.Add(this.lblMetragemFolguista);
            this.Controls.Add(this.lblEficienciaFolguista);
            this.Controls.Add(this.txtMetragemFolguista);
            this.Controls.Add(this.txtEficienciaFolguista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxCorNumero);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbxDesenhoNumero);
            this.Controls.Add(this.lblDesenhoNumero);
            this.Controls.Add(this.btnCarregarEficiencias);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gbxSituacaoTear);
            this.Controls.Add(this.lblCorNumero);
            this.Controls.Add(this.gpbEficienciasMetragens);
            this.Controls.Add(this.gbxObs);
            this.Controls.Add(this.gbxProcessoTear);
            this.Controls.Add(this.gbxEficienciaTurnos);
            this.Name = "FrmCrudProducaoTecelagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Produção Tecelagem";
            this.gbxEficienciaTurnos.ResumeLayout(false);
            this.gbxEficienciaTurnos.PerformLayout();
            this.gbxProcessoTear.ResumeLayout(false);
            this.gbxProcessoTear.PerformLayout();
            this.gbxObs.ResumeLayout(false);
            this.gpbEficienciasMetragens.ResumeLayout(false);
            this.tbcEficienciasMetragens.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEficienasMetragens)).EndInit();
            this.gbxSituacaoTear.ResumeLayout(false);
            this.gbxSituacaoTear.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTearNumero;
        private System.Windows.Forms.ComboBox cbxTearNumero;
        private System.Windows.Forms.Label lblOrdemNumero;
        private System.Windows.Forms.TextBox txtRPM;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblTurnoManha;
        private System.Windows.Forms.TextBox txtEficienciaTurnoManha;
        private System.Windows.Forms.Label lblTurnoTarde;
        private System.Windows.Forms.TextBox txtEficienciaTurnoTarde;
        private System.Windows.Forms.Label lbl24hs;
        private System.Windows.Forms.TextBox txtEficiencia24hs;
        private System.Windows.Forms.Label lblTurnoNoite;
        private System.Windows.Forms.TextBox txtEficienciaTurnoNoite;
        private System.Windows.Forms.GroupBox gbxEficienciaTurnos;
        private System.Windows.Forms.GroupBox gbxProcessoTear;
        private System.Windows.Forms.Label lblCorNumero;
        private System.Windows.Forms.GroupBox gbxObs;
        private System.Windows.Forms.RichTextBox rtxObs;
        private System.Windows.Forms.DateTimePicker dtpDataProducao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox gpbEficienciasMetragens;
        private System.Windows.Forms.TabControl tbcEficienciasMetragens;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEficienasMetragens;
        private System.Windows.Forms.GroupBox gbxSituacaoTear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxStatusTear;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblMetrosInsert;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMetrosInsert;
        private System.Windows.Forms.Label lblMetrosTurnoManha;
        private System.Windows.Forms.TextBox txtMetros24hs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMetrosTurnoNoite;
        private System.Windows.Forms.Button btnMetrosInsert;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnCarregarEficiencias;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxCorNumero;
        private System.Windows.Forms.ComboBox cbxOrdemNumero;
        private System.Windows.Forms.Label lblRoloUrdume;
        private System.Windows.Forms.ComboBox cbxDesenhoNumero;
        private System.Windows.Forms.Label lblDesenhoNumero;
        private System.Windows.Forms.ComboBox cbxRoloUrdume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStatusMotivo;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.TextBox txtMetrosTurnoTarde;
        private System.Windows.Forms.TextBox txtMetrosTurnoManha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMetragemAcumulada;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnLimparEficiencias;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpm;
        private System.Windows.Forms.ComboBox cbxRoloUrdume2;
        private System.Windows.Forms.Label lblRoloUrdume2;
        private System.Windows.Forms.CheckBox ckbTearDuplo;
        private System.Windows.Forms.CheckBox ckbFolguistaManha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbFolguistaNoite;
        private System.Windows.Forms.CheckBox ckbFolguistaTarde;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDataEficiencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folguista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn tearNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn roloUrdume;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn eficienciaRpm;
        private System.Windows.Forms.DataGridViewTextBoxColumn eManha;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn e24hs;
        private System.Windows.Forms.DataGridViewTextBoxColumn mManha;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetragemNoites;
        private System.Windows.Forms.DataGridViewTextBoxColumn m24hs;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataProducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.TextBox txtEficienciaFolguista;
        private System.Windows.Forms.Label lblEficienciaFolguista;
        private System.Windows.Forms.Label lblMetragemFolguista;
        private System.Windows.Forms.TextBox txtMetragemFolguista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label lblMetragemLancadaTotalManha;
        private System.Windows.Forms.Label lblMetragemLancadaTotalNoite;
        private System.Windows.Forms.Label lblMetragemLancadaTotalTarde;
        private System.Windows.Forms.Label lblNumeroBatidas;
        private System.Windows.Forms.TextBox txtNumeroBatidas;
        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.TextBox txtCorte;
    }
}