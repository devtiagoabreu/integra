namespace PromodaIntegra
{
    partial class FrmVincularPedidosOP
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
            this.gbxDadosDaOP = new System.Windows.Forms.GroupBox();
            this.gbxPedidosOP = new System.Windows.Forms.GroupBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblNumeroOP = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblMetragem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRomaneio = new System.Windows.Forms.Label();
            this.txtRomaneio = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblDataOP = new System.Windows.Forms.Label();
            this.dtpDataOP = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxOPs = new System.Windows.Forms.GroupBox();
            this.dgvOPs = new System.Windows.Forms.DataGridView();
            this.txtOP = new System.Windows.Forms.TextBox();
            this.lblOP = new System.Windows.Forms.Label();
            this.btnAbrirOP = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.btnVincularPedido = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.gbxDadosDaOP.SuspendLayout();
            this.gbxPedidosOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbxOPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPs)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDadosDaOP
            // 
            this.gbxDadosDaOP.Controls.Add(this.label1);
            this.gbxDadosDaOP.Controls.Add(this.richTextBox1);
            this.gbxDadosDaOP.Controls.Add(this.dtpDataOP);
            this.gbxDadosDaOP.Controls.Add(this.lblDataOP);
            this.gbxDadosDaOP.Controls.Add(this.lblCor);
            this.gbxDadosDaOP.Controls.Add(this.txtCor);
            this.gbxDadosDaOP.Controls.Add(this.lblRomaneio);
            this.gbxDadosDaOP.Controls.Add(this.txtRomaneio);
            this.gbxDadosDaOP.Controls.Add(this.lblMetragem);
            this.gbxDadosDaOP.Controls.Add(this.textBox1);
            this.gbxDadosDaOP.Controls.Add(this.lblProduto);
            this.gbxDadosDaOP.Controls.Add(this.txtProduto);
            this.gbxDadosDaOP.Controls.Add(this.lblNumeroOP);
            this.gbxDadosDaOP.Controls.Add(this.txtNumero);
            this.gbxDadosDaOP.Location = new System.Drawing.Point(12, 281);
            this.gbxDadosDaOP.Name = "gbxDadosDaOP";
            this.gbxDadosDaOP.Size = new System.Drawing.Size(765, 157);
            this.gbxDadosDaOP.TabIndex = 4;
            this.gbxDadosDaOP.TabStop = false;
            this.gbxDadosDaOP.Text = "Dados da OP";
            // 
            // gbxPedidosOP
            // 
            this.gbxPedidosOP.Controls.Add(this.dgvPedidos);
            this.gbxPedidosOP.Location = new System.Drawing.Point(12, 443);
            this.gbxPedidosOP.Name = "gbxPedidosOP";
            this.gbxPedidosOP.Size = new System.Drawing.Size(765, 146);
            this.gbxPedidosOP.TabIndex = 5;
            this.gbxPedidosOP.TabStop = false;
            this.gbxPedidosOP.Text = "Pedidos Vinculados";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(6, 19);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(750, 116);
            this.dgvPedidos.TabIndex = 6;
            // 
            // lblNumeroOP
            // 
            this.lblNumeroOP.AutoSize = true;
            this.lblNumeroOP.Location = new System.Drawing.Point(9, 20);
            this.lblNumeroOP.Name = "lblNumeroOP";
            this.lblNumeroOP.Size = new System.Drawing.Size(22, 13);
            this.lblNumeroOP.TabIndex = 7;
            this.lblNumeroOP.Text = "OP";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(9, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(105, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(221, 36);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(98, 20);
            this.txtProduto.TabIndex = 8;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(221, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(79, 13);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Artigo | Produto";
            // 
            // lblMetragem
            // 
            this.lblMetragem.AutoSize = true;
            this.lblMetragem.Location = new System.Drawing.Point(421, 20);
            this.lblMetragem.Name = "lblMetragem";
            this.lblMetragem.Size = new System.Drawing.Size(54, 13);
            this.lblMetragem.TabIndex = 11;
            this.lblMetragem.Text = "Metragem";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblRomaneio
            // 
            this.lblRomaneio.AutoSize = true;
            this.lblRomaneio.Location = new System.Drawing.Point(120, 20);
            this.lblRomaneio.Name = "lblRomaneio";
            this.lblRomaneio.Size = new System.Drawing.Size(55, 13);
            this.lblRomaneio.TabIndex = 13;
            this.lblRomaneio.Text = "Romaneio";
            // 
            // txtRomaneio
            // 
            this.txtRomaneio.Location = new System.Drawing.Point(120, 36);
            this.txtRomaneio.Name = "txtRomaneio";
            this.txtRomaneio.Size = new System.Drawing.Size(95, 20);
            this.txtRomaneio.TabIndex = 12;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(325, 20);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 15;
            this.lblCor.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(325, 36);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(90, 20);
            this.txtCor.TabIndex = 14;
            // 
            // lblDataOP
            // 
            this.lblDataOP.AutoSize = true;
            this.lblDataOP.Location = new System.Drawing.Point(544, 20);
            this.lblDataOP.Name = "lblDataOP";
            this.lblDataOP.Size = new System.Drawing.Size(30, 13);
            this.lblDataOP.TabIndex = 17;
            this.lblDataOP.Text = "Data";
            // 
            // dtpDataOP
            // 
            this.dtpDataOP.Location = new System.Drawing.Point(547, 36);
            this.dtpDataOP.Name = "dtpDataOP";
            this.dtpDataOP.Size = new System.Drawing.Size(212, 20);
            this.dtpDataOP.TabIndex = 18;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 64);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Observações";
            // 
            // gbxOPs
            // 
            this.gbxOPs.Controls.Add(this.dgvOPs);
            this.gbxOPs.Location = new System.Drawing.Point(12, 12);
            this.gbxOPs.Name = "gbxOPs";
            this.gbxOPs.Size = new System.Drawing.Size(768, 220);
            this.gbxOPs.TabIndex = 7;
            this.gbxOPs.TabStop = false;
            this.gbxOPs.Text = "OP\'s";
            // 
            // dgvOPs
            // 
            this.dgvOPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPs.Location = new System.Drawing.Point(9, 19);
            this.dgvOPs.Name = "dgvOPs";
            this.dgvOPs.Size = new System.Drawing.Size(750, 195);
            this.dgvOPs.TabIndex = 6;
            // 
            // txtOP
            // 
            this.txtOP.Location = new System.Drawing.Point(12, 255);
            this.txtOP.Name = "txtOP";
            this.txtOP.Size = new System.Drawing.Size(200, 20);
            this.txtOP.TabIndex = 1;
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(9, 239);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(22, 13);
            this.lblOP.TabIndex = 2;
            this.lblOP.Text = "OP";
            // 
            // btnAbrirOP
            // 
            this.btnAbrirOP.Location = new System.Drawing.Point(221, 252);
            this.btnAbrirOP.Name = "btnAbrirOP";
            this.btnAbrirOP.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirOP.TabIndex = 3;
            this.btnAbrirOP.Text = "Abrir";
            this.btnAbrirOP.UseVisualStyleBackColor = true;
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(492, 252);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(200, 20);
            this.txtPedido.TabIndex = 6;
            // 
            // btnVincularPedido
            // 
            this.btnVincularPedido.Location = new System.Drawing.Point(698, 250);
            this.btnVincularPedido.Name = "btnVincularPedido";
            this.btnVincularPedido.Size = new System.Drawing.Size(75, 23);
            this.btnVincularPedido.TabIndex = 7;
            this.btnVincularPedido.Text = "Vincular";
            this.btnVincularPedido.UseVisualStyleBackColor = true;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(489, 236);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(40, 13);
            this.lblPedido.TabIndex = 8;
            this.lblPedido.Text = "Pedido";
            // 
            // FrmVincularPedidosOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 598);
            this.Controls.Add(this.gbxOPs);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.btnVincularPedido);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.gbxPedidosOP);
            this.Controls.Add(this.gbxDadosDaOP);
            this.Controls.Add(this.btnAbrirOP);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.txtOP);
            this.Name = "FrmVincularPedidosOP";
            this.Text = "FrmVincularPedidosOP";
            this.gbxDadosDaOP.ResumeLayout(false);
            this.gbxDadosDaOP.PerformLayout();
            this.gbxPedidosOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbxOPs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDadosDaOP;
        private System.Windows.Forms.GroupBox gbxPedidosOP;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblNumeroOP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblRomaneio;
        private System.Windows.Forms.TextBox txtRomaneio;
        private System.Windows.Forms.Label lblMetragem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dtpDataOP;
        private System.Windows.Forms.Label lblDataOP;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.GroupBox gbxOPs;
        private System.Windows.Forms.DataGridView dgvOPs;
        private System.Windows.Forms.TextBox txtOP;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Button btnAbrirOP;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Button btnVincularPedido;
        private System.Windows.Forms.Label lblPedido;
    }
}