namespace PromodaIntegra
{
    partial class FrmRelatorioConsumoDeFiosDeTramaSintetico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioConsumoDeFiosDeTramaSintetico));
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.lblCodigoFio = new System.Windows.Forms.Label();
            this.txtCodigoFio = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.rptRelatorioConsumoDeFiosDeTramaSintetico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico = new PromodaIntegra.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico();
            this.uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspRelatorioConsumoDeFiosDeTramaSinteticoTableAdapter = new PromodaIntegra.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSinteticoTableAdapters.uspRelatorioConsumoDeFiosDeTramaSinteticoTableAdapter();
            this.gbxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxParametros
            // 
            this.gbxParametros.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxParametros.Controls.Add(this.lblCodigoFio);
            this.gbxParametros.Controls.Add(this.txtCodigoFio);
            this.gbxParametros.Controls.Add(this.lblCodigoProduto);
            this.gbxParametros.Controls.Add(this.txtCodigoProduto);
            this.gbxParametros.Controls.Add(this.label2);
            this.gbxParametros.Controls.Add(this.label1);
            this.gbxParametros.Controls.Add(this.dtpDataFinal);
            this.gbxParametros.Controls.Add(this.dtpDataInicial);
            this.gbxParametros.Location = new System.Drawing.Point(3, 3);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(571, 104);
            this.gbxParametros.TabIndex = 13;
            this.gbxParametros.TabStop = false;
            this.gbxParametros.Text = "Parâmetros";
            // 
            // lblCodigoFio
            // 
            this.lblCodigoFio.AutoSize = true;
            this.lblCodigoFio.Location = new System.Drawing.Point(7, 61);
            this.lblCodigoFio.Name = "lblCodigoFio";
            this.lblCodigoFio.Size = new System.Drawing.Size(21, 13);
            this.lblCodigoFio.TabIndex = 3;
            this.lblCodigoFio.Text = "&Fio";
            // 
            // txtCodigoFio
            // 
            this.txtCodigoFio.Location = new System.Drawing.Point(6, 77);
            this.txtCodigoFio.Name = "txtCodigoFio";
            this.txtCodigoFio.Size = new System.Drawing.Size(115, 20);
            this.txtCodigoFio.TabIndex = 4;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(3, 20);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(73, 13);
            this.lblCodigoProduto.TabIndex = 1;
            this.lblCodigoProduto.Text = "&Ordem | Artigo";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(6, 35);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(115, 20);
            this.txtCodigoProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fi&m:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "&Início:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Location = new System.Drawing.Point(350, 35);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(210, 20);
            this.dtpDataFinal.TabIndex = 8;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Location = new System.Drawing.Point(132, 35);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(210, 20);
            this.dtpDataInicial.TabIndex = 6;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Silver;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(581, 11);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(94, 36);
            this.btnGerarRelatorio.TabIndex = 14;
            this.btnGerarRelatorio.Text = "&Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // rptRelatorioConsumoDeFiosDeTramaSintetico
            // 
            reportDataSource1.Name = "DataSetRelatorioConsumoDeFiosDeTramaSintetico";
            reportDataSource1.Value = this.uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource;
            this.rptRelatorioConsumoDeFiosDeTramaSintetico.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelatorioConsumoDeFiosDeTramaSintetico.LocalReport.ReportEmbeddedResource = "PromodaIntegra.RelatorioConsumoDeFiosDeTramaSintetico.rdlc";
            this.rptRelatorioConsumoDeFiosDeTramaSintetico.Location = new System.Drawing.Point(5, 113);
            this.rptRelatorioConsumoDeFiosDeTramaSintetico.Name = "rptRelatorioConsumoDeFiosDeTramaSintetico";
            this.rptRelatorioConsumoDeFiosDeTramaSintetico.Size = new System.Drawing.Size(672, 530);
            this.rptRelatorioConsumoDeFiosDeTramaSintetico.TabIndex = 15;
            // 
            // DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico
            // 
            this.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico.DataSetName = "DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico";
            this.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource
            // 
            this.uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource.DataMember = "uspRelatorioConsumoDeFiosDeTramaSintetico";
            this.uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource.DataSource = this.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico;
            // 
            // uspRelatorioConsumoDeFiosDeTramaSinteticoTableAdapter
            // 
            this.uspRelatorioConsumoDeFiosDeTramaSinteticoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioConsumoDeFiosDeTramaSintetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(686, 656);
            this.Controls.Add(this.rptRelatorioConsumoDeFiosDeTramaSintetico);
            this.Controls.Add(this.gbxParametros);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioConsumoDeFiosDeTramaSintetico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Consumo de Fios  - Trama - Sintético";
            this.Load += new System.EventHandler(this.FrmRelatorioConsumoDeFiosDeTramaSintetico_Load);
            this.gbxParametros.ResumeLayout(false);
            this.gbxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.Label lblCodigoFio;
        private System.Windows.Forms.TextBox txtCodigoFio;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private Microsoft.Reporting.WinForms.ReportViewer rptRelatorioConsumoDeFiosDeTramaSintetico;
        private System.Windows.Forms.BindingSource uspRelatorioConsumoDeFiosDeTramaSinteticoBindingSource;
        private DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSintetico;
        private DBPromodaDataSetRelatorioConsumoDeFiosDeTramaSinteticoTableAdapters.uspRelatorioConsumoDeFiosDeTramaSinteticoTableAdapter uspRelatorioConsumoDeFiosDeTramaSinteticoTableAdapter;
    }
}