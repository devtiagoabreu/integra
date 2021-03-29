namespace PromodaIntegra
{
    partial class FrmRelListagemDePecas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelListagemDePecas));
            this.uspRelListagemDePecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBPromodaDataSetUspRelListagemDePecas = new PromodaIntegra.DBPromodaDataSetUspRelListagemDePecas();
            this.rptRelListagemDePecas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnIndicadores = new System.Windows.Forms.Button();
            this.uspRelListagemDePecasTableAdapter = new PromodaIntegra.DBPromodaDataSetUspRelListagemDePecasTableAdapters.uspRelListagemDePecasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspRelListagemDePecasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPromodaDataSetUspRelListagemDePecas)).BeginInit();
            this.gbxParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // uspRelListagemDePecasBindingSource
            // 
            this.uspRelListagemDePecasBindingSource.DataMember = "uspRelListagemDePecas";
            this.uspRelListagemDePecasBindingSource.DataSource = this.DBPromodaDataSetUspRelListagemDePecas;
            // 
            // DBPromodaDataSetUspRelListagemDePecas
            // 
            this.DBPromodaDataSetUspRelListagemDePecas.DataSetName = "DBPromodaDataSetUspRelListagemDePecas";
            this.DBPromodaDataSetUspRelListagemDePecas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptRelListagemDePecas
            // 
            this.rptRelListagemDePecas.BackColor = System.Drawing.Color.LightGray;
            reportDataSource1.Name = "DataSetRelListagemDePecas";
            reportDataSource1.Value = this.uspRelListagemDePecasBindingSource;
            this.rptRelListagemDePecas.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelListagemDePecas.LocalReport.ReportEmbeddedResource = "PromodaIntegra.RelListagemDePecas.rdlc";
            this.rptRelListagemDePecas.Location = new System.Drawing.Point(12, 99);
            this.rptRelListagemDePecas.Name = "rptRelListagemDePecas";
            this.rptRelListagemDePecas.Size = new System.Drawing.Size(692, 527);
            this.rptRelListagemDePecas.TabIndex = 9;
            // 
            // gbxParametros
            // 
            this.gbxParametros.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxParametros.Controls.Add(this.lblCodigoProduto);
            this.gbxParametros.Controls.Add(this.txtCodigoProduto);
            this.gbxParametros.Controls.Add(this.label2);
            this.gbxParametros.Controls.Add(this.label1);
            this.gbxParametros.Controls.Add(this.dtpDataFinal);
            this.gbxParametros.Controls.Add(this.dtpDataInicial);
            this.gbxParametros.Location = new System.Drawing.Point(12, 9);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(592, 84);
            this.gbxParametros.TabIndex = 0;
            this.gbxParametros.TabStop = false;
            this.gbxParametros.Text = "Parâmetros";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(1, 19);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(73, 13);
            this.lblCodigoProduto.TabIndex = 1;
            this.lblCodigoProduto.Text = "&Ordem | Artigo";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(4, 35);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(126, 20);
            this.txtCodigoProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fi&m:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Início:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Location = new System.Drawing.Point(371, 35);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(210, 20);
            this.dtpDataFinal.TabIndex = 6;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Location = new System.Drawing.Point(155, 35);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(210, 20);
            this.dtpDataInicial.TabIndex = 4;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Silver;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(610, 12);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(94, 36);
            this.btnGerarRelatorio.TabIndex = 7;
            this.btnGerarRelatorio.Text = "&Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnIndicadores
            // 
            this.btnIndicadores.BackColor = System.Drawing.Color.Silver;
            this.btnIndicadores.Location = new System.Drawing.Point(610, 57);
            this.btnIndicadores.Name = "btnIndicadores";
            this.btnIndicadores.Size = new System.Drawing.Size(94, 36);
            this.btnIndicadores.TabIndex = 8;
            this.btnIndicadores.Text = "&Sintético";
            this.btnIndicadores.UseVisualStyleBackColor = false;
            this.btnIndicadores.Click += new System.EventHandler(this.btnIndicadores_Click);
            // 
            // uspRelListagemDePecasTableAdapter
            // 
            this.uspRelListagemDePecasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelListagemDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(716, 638);
            this.Controls.Add(this.btnIndicadores);
            this.Controls.Add(this.gbxParametros);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.rptRelListagemDePecas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelListagemDePecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Listagem de Peças - Tecido Cru";
            this.Load += new System.EventHandler(this.FrmRelListagemDePecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspRelListagemDePecasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPromodaDataSetUspRelListagemDePecas)).EndInit();
            this.gbxParametros.ResumeLayout(false);
            this.gbxParametros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelListagemDePecas;
        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnIndicadores;
        private System.Windows.Forms.BindingSource uspRelListagemDePecasBindingSource;
        private DBPromodaDataSetUspRelListagemDePecas DBPromodaDataSetUspRelListagemDePecas;
        private DBPromodaDataSetUspRelListagemDePecasTableAdapters.uspRelListagemDePecasTableAdapter uspRelListagemDePecasTableAdapter;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
    }
}