namespace PromodaIntegra
{
    partial class FrmDREInserirDadosComplementares
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
            this.lblData = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblReferente = new System.Windows.Forms.Label();
            this.cbxReferente = new System.Windows.Forms.ComboBox();
            this.dgvDREDadosComplementares = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDREDadosComplementares)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(457, 16);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "DATA";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(9, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            this.txtValor.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(460, 32);
            this.dtpData.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 16);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "VALOR";
            // 
            // lblReferente
            // 
            this.lblReferente.AutoSize = true;
            this.lblReferente.Location = new System.Drawing.Point(215, 16);
            this.lblReferente.Name = "lblReferente";
            this.lblReferente.Size = new System.Drawing.Size(82, 13);
            this.lblReferente.TabIndex = 5;
            this.lblReferente.Text = "REFERENTE À";
            // 
            // cbxReferente
            // 
            this.cbxReferente.FormattingEnabled = true;
            this.cbxReferente.Location = new System.Drawing.Point(218, 32);
            this.cbxReferente.Name = "cbxReferente";
            this.cbxReferente.Size = new System.Drawing.Size(230, 21);
            this.cbxReferente.TabIndex = 6;
            // 
            // dgvDREDadosComplementares
            // 
            this.dgvDREDadosComplementares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDREDadosComplementares.Location = new System.Drawing.Point(9, 100);
            this.dgvDREDadosComplementares.Name = "dgvDREDadosComplementares";
            this.dgvDREDadosComplementares.Size = new System.Drawing.Size(651, 357);
            this.dgvDREDadosComplementares.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 71);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(94, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmDREInserirDadosComplementares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 469);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvDREDadosComplementares);
            this.Controls.Add(this.cbxReferente);
            this.Controls.Add(this.lblReferente);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblData);
            this.Name = "FrmDREInserirDadosComplementares";
            this.Text = "DRE - Dados Complementares";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDREDadosComplementares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblReferente;
        private System.Windows.Forms.ComboBox cbxReferente;
        private System.Windows.Forms.DataGridView dgvDREDadosComplementares;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}