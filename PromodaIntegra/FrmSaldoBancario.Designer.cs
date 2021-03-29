namespace PromodaIntegra
{
    partial class FrmSaldoBancario
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
            this.lblNovoSaldo = new System.Windows.Forms.Label();
            this.txtNovoSaldo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNovoSaldo
            // 
            this.lblNovoSaldo.AutoSize = true;
            this.lblNovoSaldo.Location = new System.Drawing.Point(12, 13);
            this.lblNovoSaldo.Name = "lblNovoSaldo";
            this.lblNovoSaldo.Size = new System.Drawing.Size(63, 13);
            this.lblNovoSaldo.TabIndex = 0;
            this.lblNovoSaldo.Text = "Novo Saldo";
            // 
            // txtNovoSaldo
            // 
            this.txtNovoSaldo.Location = new System.Drawing.Point(10, 29);
            this.txtNovoSaldo.Name = "txtNovoSaldo";
            this.txtNovoSaldo.Size = new System.Drawing.Size(143, 20);
            this.txtNovoSaldo.TabIndex = 1;
            this.txtNovoSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoSaldo_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(159, 27);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(3, 107);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(88, 39);
            this.lblSaldoAtual.TabIndex = 6;
            this.lblSaldoAtual.Text = "0,00";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(68, 60);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(23, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo Atual";
            // 
            // FrmSaldoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNovoSaldo);
            this.Controls.Add(this.lblNovoSaldo);
            this.Name = "FrmSaldoBancario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo Bancário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovoSaldo;
        private System.Windows.Forms.TextBox txtNovoSaldo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
    }
}