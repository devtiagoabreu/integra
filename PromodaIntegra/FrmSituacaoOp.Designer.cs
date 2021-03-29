namespace PromodaIntegra
{
    partial class FrmSituacaoOp
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
            this.cbxProcesso = new System.Windows.Forms.ComboBox();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.btnExibirProcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxProcesso
            // 
            this.cbxProcesso.FormattingEnabled = true;
            this.cbxProcesso.Location = new System.Drawing.Point(12, 32);
            this.cbxProcesso.Name = "cbxProcesso";
            this.cbxProcesso.Size = new System.Drawing.Size(223, 21);
            this.cbxProcesso.TabIndex = 1;
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(13, 13);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(51, 13);
            this.lblProcesso.TabIndex = 2;
            this.lblProcesso.Text = "Processo";
            // 
            // btnExibirProcesso
            // 
            this.btnExibirProcesso.Location = new System.Drawing.Point(241, 32);
            this.btnExibirProcesso.Name = "btnExibirProcesso";
            this.btnExibirProcesso.Size = new System.Drawing.Size(99, 23);
            this.btnExibirProcesso.TabIndex = 3;
            this.btnExibirProcesso.Text = "Exibir  Processo";
            this.btnExibirProcesso.UseVisualStyleBackColor = true;
            this.btnExibirProcesso.Click += new System.EventHandler(this.btnExibirProcesso_Click);
            // 
            // FrmSituacaoOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 336);
            this.Controls.Add(this.btnExibirProcesso);
            this.Controls.Add(this.lblProcesso);
            this.Controls.Add(this.cbxProcesso);
            this.IsMdiContainer = true;
            this.Name = "FrmSituacaoOp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situação das OPs em Processo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProcesso;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Button btnExibirProcesso;
    }
}