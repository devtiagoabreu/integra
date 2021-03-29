namespace PromodaIntegra
{
    partial class FrmPedidosDepartamentalizacao
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
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(12, 32);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(290, 20);
            this.txtPedido.TabIndex = 0;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(12, 74);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(290, 21);
            this.cbxDepartamento.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(12, 16);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(70, 13);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Nº do Pedido";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(227, 120);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(9, 58);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 4;
            this.lblDepartamento.Text = "Departamento";
            // 
            // FrmPedidosDepartamentalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 155);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.txtPedido);
            this.Name = "FrmPedidosDepartamentalizacao";
            this.Text = "Departamentalização";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDepartamento;
    }
}