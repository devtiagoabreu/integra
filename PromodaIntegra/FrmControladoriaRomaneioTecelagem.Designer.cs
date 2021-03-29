namespace PromodaIntegra
{
    partial class FrmControladoriaRomaneioTecelagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRomaneioTecelagemId = new System.Windows.Forms.Label();
            this.dgvPecasRomaneio = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumeroPeca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroRomaneio = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbPecasRomaneio = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControladoriaRomaneioTecelagemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperadorNumero_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Rolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasRomaneio)).BeginInit();
            this.gpbPecasRomaneio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRomaneioTecelagemId
            // 
            this.lblRomaneioTecelagemId.AutoSize = true;
            this.lblRomaneioTecelagemId.Location = new System.Drawing.Point(13, 13);
            this.lblRomaneioTecelagemId.Name = "lblRomaneioTecelagemId";
            this.lblRomaneioTecelagemId.Size = new System.Drawing.Size(40, 13);
            this.lblRomaneioTecelagemId.TabIndex = 0;
            this.lblRomaneioTecelagemId.Text = "Código";
            // 
            // dgvPecasRomaneio
            // 
            this.dgvPecasRomaneio.AllowUserToAddRows = false;
            this.dgvPecasRomaneio.AllowUserToDeleteRows = false;
            this.dgvPecasRomaneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecasRomaneio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ControladoriaRomaneioTecelagemId,
            this.OperadorNumero_,
            this.Numero,
            this.Nro_Rolo,
            this.Nro_Peca,
            this.Metros,
            this.ativo});
            this.dgvPecasRomaneio.Location = new System.Drawing.Point(6, 19);
            this.dgvPecasRomaneio.Name = "dgvPecasRomaneio";
            this.dgvPecasRomaneio.ReadOnly = true;
            this.dgvPecasRomaneio.Size = new System.Drawing.Size(600, 311);
            this.dgvPecasRomaneio.TabIndex = 0;
            this.dgvPecasRomaneio.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPecasRomaneio_CellFormatting);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 20);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtNumeroPeca
            // 
            this.txtNumeroPeca.Location = new System.Drawing.Point(16, 75);
            this.txtNumeroPeca.Name = "txtNumeroPeca";
            this.txtNumeroPeca.Size = new System.Drawing.Size(512, 20);
            this.txtNumeroPeca.TabIndex = 5;
            this.txtNumeroPeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPeca_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número da Peça ";
            // 
            // lblNumeroRomaneio
            // 
            this.lblNumeroRomaneio.AutoSize = true;
            this.lblNumeroRomaneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRomaneio.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroRomaneio.Location = new System.Drawing.Point(109, 26);
            this.lblNumeroRomaneio.Name = "lblNumeroRomaneio";
            this.lblNumeroRomaneio.Size = new System.Drawing.Size(0, 33);
            this.lblNumeroRomaneio.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(547, 54);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 41);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(628, 54);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 41);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(612, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gpbPecasRomaneio
            // 
            this.gpbPecasRomaneio.Controls.Add(this.dgvPecasRomaneio);
            this.gpbPecasRomaneio.Controls.Add(this.btnExcluir);
            this.gpbPecasRomaneio.Location = new System.Drawing.Point(16, 101);
            this.gpbPecasRomaneio.Name = "gpbPecasRomaneio";
            this.gpbPecasRomaneio.Size = new System.Drawing.Size(690, 344);
            this.gpbPecasRomaneio.TabIndex = 7;
            this.gpbPecasRomaneio.TabStop = false;
            this.gpbPecasRomaneio.Text = "Peças do Romaneio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número do Romaneio";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ControladoriaRomaneioTecelagemId
            // 
            this.ControladoriaRomaneioTecelagemId.DataPropertyName = "ControladoriaRomaneioTecelagemId";
            this.ControladoriaRomaneioTecelagemId.HeaderText = "Romaneio";
            this.ControladoriaRomaneioTecelagemId.Name = "ControladoriaRomaneioTecelagemId";
            this.ControladoriaRomaneioTecelagemId.ReadOnly = true;
            this.ControladoriaRomaneioTecelagemId.Visible = false;
            // 
            // OperadorNumero_
            // 
            this.OperadorNumero_.DataPropertyName = "OperadorNumero";
            this.OperadorNumero_.HeaderText = "Operador";
            this.OperadorNumero_.Name = "OperadorNumero_";
            this.OperadorNumero_.ReadOnly = true;
            this.OperadorNumero_.Visible = false;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Visible = false;
            this.Numero.Width = 300;
            // 
            // Nro_Rolo
            // 
            this.Nro_Rolo.DataPropertyName = "Nro_Rolo";
            this.Nro_Rolo.HeaderText = "Nro_Rolo";
            this.Nro_Rolo.Name = "Nro_Rolo";
            this.Nro_Rolo.ReadOnly = true;
            this.Nro_Rolo.Width = 240;
            // 
            // Nro_Peca
            // 
            this.Nro_Peca.DataPropertyName = "Nro_Peca";
            this.Nro_Peca.HeaderText = "Nro_Peca";
            this.Nro_Peca.Name = "Nro_Peca";
            this.Nro_Peca.ReadOnly = true;
            this.Nro_Peca.Width = 70;
            // 
            // Metros
            // 
            this.Metros.DataPropertyName = "Metros";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Metros.DefaultCellStyle = dataGridViewCellStyle1;
            this.Metros.HeaderText = "Metros";
            this.Metros.Name = "Metros";
            this.Metros.ReadOnly = true;
            this.Metros.Width = 240;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "Ativo";
            this.ativo.HeaderText = "OK";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Width = 5;
            // 
            // FrmControladoriaRomaneioTecelagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpbPecasRomaneio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblNumeroRomaneio);
            this.Controls.Add(this.txtNumeroPeca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblRomaneioTecelagemId);
            this.Name = "FrmControladoriaRomaneioTecelagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Controladoria Romaneio Tecelagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasRomaneio)).EndInit();
            this.gpbPecasRomaneio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRomaneioTecelagemId;
        private System.Windows.Forms.DataGridView dgvPecasRomaneio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNumeroPeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroRomaneio;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gpbPecasRomaneio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControladoriaRomaneioTecelagemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperadorNumero_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Rolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
    }
}