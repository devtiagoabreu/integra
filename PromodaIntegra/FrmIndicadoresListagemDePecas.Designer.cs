namespace PromodaIntegra
{
    partial class FrmIndicadoresListagemDePecas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndicadoresListagemDePecas));
            this.uspRelListagemDePecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBPromodaDataSetUspRelListagemDePecas = new PromodaIntegra.DBPromodaDataSetUspRelListagemDePecas();
            this.rptIndicadoresListagemDePecasDataAtual = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptIndicadoresListagemDePecasMesPassado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspRelListagemDePecasTableAdapter = new PromodaIntegra.DBPromodaDataSetUspRelListagemDePecasTableAdapters.uspRelListagemDePecasTableAdapter();
            this.dtpDataInicialMesAtual = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinalMesAtual = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicialMesPassado = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinalMesPassado = new System.Windows.Forms.DateTimePicker();
            this.timerIndicadoresMesAtual = new System.Windows.Forms.Timer(this.components);
            this.timerIndicadoresMesPassado = new System.Windows.Forms.Timer(this.components);
            this.timerEnableTimers = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uspRelListagemDePecasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPromodaDataSetUspRelListagemDePecas)).BeginInit();
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
            // rptIndicadoresListagemDePecasDataAtual
            // 
            this.rptIndicadoresListagemDePecasDataAtual.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource1.Name = "DataSetIndicadoresListagemDePecas";
            reportDataSource1.Value = this.uspRelListagemDePecasBindingSource;
            this.rptIndicadoresListagemDePecasDataAtual.LocalReport.DataSources.Add(reportDataSource1);
            this.rptIndicadoresListagemDePecasDataAtual.LocalReport.ReportEmbeddedResource = "PromodaIntegra.IndicadoresListagemDePecasDataAtual.rdlc";
            this.rptIndicadoresListagemDePecasDataAtual.Location = new System.Drawing.Point(12, 12);
            this.rptIndicadoresListagemDePecasDataAtual.Name = "rptIndicadoresListagemDePecasDataAtual";
            this.rptIndicadoresListagemDePecasDataAtual.Size = new System.Drawing.Size(1318, 336);
            this.rptIndicadoresListagemDePecasDataAtual.TabIndex = 0;
            // 
            // rptIndicadoresListagemDePecasMesPassado
            // 
            this.rptIndicadoresListagemDePecasMesPassado.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource2.Name = "DataSetIndicadorListagemDePecasMesPassadoDataAtual";
            reportDataSource2.Value = this.uspRelListagemDePecasBindingSource;
            this.rptIndicadoresListagemDePecasMesPassado.LocalReport.DataSources.Add(reportDataSource2);
            this.rptIndicadoresListagemDePecasMesPassado.LocalReport.ReportEmbeddedResource = "PromodaIntegra.IndicadoresListagemDePecasMesPassado.rdlc";
            this.rptIndicadoresListagemDePecasMesPassado.Location = new System.Drawing.Point(12, 354);
            this.rptIndicadoresListagemDePecasMesPassado.Name = "rptIndicadoresListagemDePecasMesPassado";
            this.rptIndicadoresListagemDePecasMesPassado.Size = new System.Drawing.Size(1318, 336);
            this.rptIndicadoresListagemDePecasMesPassado.TabIndex = 1;
            // 
            // uspRelListagemDePecasTableAdapter
            // 
            this.uspRelListagemDePecasTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDataInicialMesAtual
            // 
            this.dtpDataInicialMesAtual.Location = new System.Drawing.Point(180, 673);
            this.dtpDataInicialMesAtual.Name = "dtpDataInicialMesAtual";
            this.dtpDataInicialMesAtual.Size = new System.Drawing.Size(200, 22);
            this.dtpDataInicialMesAtual.TabIndex = 2;
            this.dtpDataInicialMesAtual.Visible = false;
            // 
            // dtpDataFinalMesAtual
            // 
            this.dtpDataFinalMesAtual.Location = new System.Drawing.Point(434, 673);
            this.dtpDataFinalMesAtual.Name = "dtpDataFinalMesAtual";
            this.dtpDataFinalMesAtual.Size = new System.Drawing.Size(200, 22);
            this.dtpDataFinalMesAtual.TabIndex = 3;
            this.dtpDataFinalMesAtual.Visible = false;
            // 
            // dtpDataInicialMesPassado
            // 
            this.dtpDataInicialMesPassado.Location = new System.Drawing.Point(676, 673);
            this.dtpDataInicialMesPassado.Name = "dtpDataInicialMesPassado";
            this.dtpDataInicialMesPassado.Size = new System.Drawing.Size(200, 22);
            this.dtpDataInicialMesPassado.TabIndex = 2;
            this.dtpDataInicialMesPassado.Visible = false;
            // 
            // dtpDataFinalMesPassado
            // 
            this.dtpDataFinalMesPassado.Location = new System.Drawing.Point(930, 673);
            this.dtpDataFinalMesPassado.Name = "dtpDataFinalMesPassado";
            this.dtpDataFinalMesPassado.Size = new System.Drawing.Size(200, 22);
            this.dtpDataFinalMesPassado.TabIndex = 3;
            this.dtpDataFinalMesPassado.Visible = false;
            // 
            // timerIndicadoresMesAtual
            // 
            this.timerIndicadoresMesAtual.Enabled = true;
            this.timerIndicadoresMesAtual.Interval = 1000;
            this.timerIndicadoresMesAtual.Tick += new System.EventHandler(this.timerIndicadoresMesAtual_Tick);
            // 
            // timerIndicadoresMesPassado
            // 
            this.timerIndicadoresMesPassado.Enabled = true;
            this.timerIndicadoresMesPassado.Interval = 5000;
            this.timerIndicadoresMesPassado.Tick += new System.EventHandler(this.timerIndicadoresMesPassado_Tick);
            // 
            // timerEnableTimers
            // 
            this.timerEnableTimers.Enabled = true;
            this.timerEnableTimers.Interval = 900000;
            this.timerEnableTimers.Tick += new System.EventHandler(this.timerEnableTimers_Tick);
            // 
            // FrmIndicadoresListagemDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1342, 702);
            this.Controls.Add(this.dtpDataFinalMesPassado);
            this.Controls.Add(this.dtpDataInicialMesPassado);
            this.Controls.Add(this.dtpDataFinalMesAtual);
            this.Controls.Add(this.dtpDataInicialMesAtual);
            this.Controls.Add(this.rptIndicadoresListagemDePecasMesPassado);
            this.Controls.Add(this.rptIndicadoresListagemDePecasDataAtual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIndicadoresListagemDePecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicadores - Listagem de Peças";
            this.Load += new System.EventHandler(this.FrmIndicadoresListagemDePecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspRelListagemDePecasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPromodaDataSetUspRelListagemDePecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptIndicadoresListagemDePecasDataAtual;
        private Microsoft.Reporting.WinForms.ReportViewer rptIndicadoresListagemDePecasMesPassado;
        private System.Windows.Forms.BindingSource uspRelListagemDePecasBindingSource;
        private DBPromodaDataSetUspRelListagemDePecas DBPromodaDataSetUspRelListagemDePecas;
        private DBPromodaDataSetUspRelListagemDePecasTableAdapters.uspRelListagemDePecasTableAdapter uspRelListagemDePecasTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDataInicialMesAtual;
        private System.Windows.Forms.DateTimePicker dtpDataFinalMesAtual;
        private System.Windows.Forms.DateTimePicker dtpDataInicialMesPassado;
        private System.Windows.Forms.DateTimePicker dtpDataFinalMesPassado;
        private System.Windows.Forms.Timer timerIndicadoresMesAtual;
        private System.Windows.Forms.Timer timerIndicadoresMesPassado;
        private System.Windows.Forms.Timer timerEnableTimers;
    }
}