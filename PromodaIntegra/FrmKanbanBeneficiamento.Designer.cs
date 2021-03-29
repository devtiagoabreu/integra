namespace PromodaIntegra
{
    partial class FrmKanbanBeneficiamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProgramadas = new System.Windows.Forms.DataGridView();
            this.op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmProducao = new System.Windows.Forms.DataGridView();
            this.opEmOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFinalizadas = new System.Windows.Forms.DataGridView();
            this.opFinalizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProgramadas = new System.Windows.Forms.Label();
            this.lblEmProducao = new System.Windows.Forms.Label();
            this.lblFinalizadas = new System.Windows.Forms.Label();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.timerUpdateGrids = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizadas)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProgramadas
            // 
            this.dgvProgramadas.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvProgramadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProgramadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.op});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgramadas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProgramadas.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvProgramadas.Location = new System.Drawing.Point(3, 69);
            this.dgvProgramadas.Name = "dgvProgramadas";
            this.dgvProgramadas.Size = new System.Drawing.Size(141, 216);
            this.dgvProgramadas.TabIndex = 0;
            // 
            // op
            // 
            this.op.DataPropertyName = "OP";
            this.op.HeaderText = "OP";
            this.op.Name = "op";
            this.op.Width = 80;
            // 
            // dgvEmProducao
            // 
            this.dgvEmProducao.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvEmProducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmProducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opEmOperacao});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmProducao.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmProducao.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvEmProducao.Location = new System.Drawing.Point(150, 69);
            this.dgvEmProducao.Name = "dgvEmProducao";
            this.dgvEmProducao.Size = new System.Drawing.Size(141, 216);
            this.dgvEmProducao.TabIndex = 1;
            // 
            // opEmOperacao
            // 
            this.opEmOperacao.DataPropertyName = "OP";
            this.opEmOperacao.HeaderText = "OP";
            this.opEmOperacao.Name = "opEmOperacao";
            this.opEmOperacao.Width = 80;
            // 
            // dgvFinalizadas
            // 
            this.dgvFinalizadas.BackgroundColor = System.Drawing.Color.Crimson;
            this.dgvFinalizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opFinalizadas});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinalizadas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFinalizadas.GridColor = System.Drawing.Color.Crimson;
            this.dgvFinalizadas.Location = new System.Drawing.Point(297, 69);
            this.dgvFinalizadas.Name = "dgvFinalizadas";
            this.dgvFinalizadas.Size = new System.Drawing.Size(141, 216);
            this.dgvFinalizadas.TabIndex = 2;
            // 
            // opFinalizadas
            // 
            this.opFinalizadas.DataPropertyName = "OP";
            this.opFinalizadas.HeaderText = "OP";
            this.opFinalizadas.Name = "opFinalizadas";
            this.opFinalizadas.Width = 80;
            // 
            // lblProgramadas
            // 
            this.lblProgramadas.AutoSize = true;
            this.lblProgramadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProgramadas.Location = new System.Drawing.Point(24, 44);
            this.lblProgramadas.Name = "lblProgramadas";
            this.lblProgramadas.Size = new System.Drawing.Size(102, 16);
            this.lblProgramadas.TabIndex = 3;
            this.lblProgramadas.Text = "Programadas";
            // 
            // lblEmProducao
            // 
            this.lblEmProducao.AutoSize = true;
            this.lblEmProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmProducao.Location = new System.Drawing.Point(172, 44);
            this.lblEmProducao.Name = "lblEmProducao";
            this.lblEmProducao.Size = new System.Drawing.Size(103, 16);
            this.lblEmProducao.TabIndex = 4;
            this.lblEmProducao.Text = "Em Operação";
            // 
            // lblFinalizadas
            // 
            this.lblFinalizadas.AutoSize = true;
            this.lblFinalizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizadas.Location = new System.Drawing.Point(323, 44);
            this.lblFinalizadas.Name = "lblFinalizadas";
            this.lblFinalizadas.Size = new System.Drawing.Size(88, 16);
            this.lblFinalizadas.TabIndex = 5;
            this.lblFinalizadas.Text = "Finalizadas";
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesso.ForeColor = System.Drawing.Color.White;
            this.lblProcesso.Location = new System.Drawing.Point(9, 3);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(83, 20);
            this.lblProcesso.TabIndex = 6;
            this.lblProcesso.Text = "Processo";
            this.lblProcesso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblProcesso_MouseDown);
            this.lblProcesso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblProcesso_MouseMove);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.Controls.Add(this.lblFechar);
            this.pnlHeader.Controls.Add(this.lblProcesso);
            this.pnlHeader.Location = new System.Drawing.Point(-5, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(452, 27);
            this.pnlHeader.TabIndex = 7;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(424, 2);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(21, 24);
            this.lblFechar.TabIndex = 7;
            this.lblFechar.Text = "x";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // timerUpdateGrids
            // 
            this.timerUpdateGrids.Enabled = true;
            this.timerUpdateGrids.Interval = 60000;
            this.timerUpdateGrids.Tick += new System.EventHandler(this.timerUpdateGrids_Tick);
            // 
            // FrmKanbanBeneficiamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 287);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblFinalizadas);
            this.Controls.Add(this.lblEmProducao);
            this.Controls.Add(this.lblProgramadas);
            this.Controls.Add(this.dgvFinalizadas);
            this.Controls.Add(this.dgvEmProducao);
            this.Controls.Add(this.dgvProgramadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKanbanBeneficiamento";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban Board";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizadas)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProgramadas;
        private System.Windows.Forms.DataGridView dgvEmProducao;
        private System.Windows.Forms.DataGridView dgvFinalizadas;
        private System.Windows.Forms.Label lblProgramadas;
        private System.Windows.Forms.Label lblEmProducao;
        private System.Windows.Forms.Label lblFinalizadas;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn op;
        private System.Windows.Forms.DataGridViewTextBoxColumn opEmOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn opFinalizadas;
        private System.Windows.Forms.Timer timerUpdateGrids;
    }
}