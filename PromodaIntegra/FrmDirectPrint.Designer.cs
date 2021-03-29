namespace PromodaIntegra
{
    partial class FrmDirectPrint
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
            this.cbxPrinters = new System.Windows.Forms.ComboBox();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.lblComposition = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblLotRoll = new System.Windows.Forms.Label();
            this.lblNetWeight = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPoNumber = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblPrintersList = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPrinters
            // 
            this.cbxPrinters.FormattingEnabled = true;
            this.cbxPrinters.Location = new System.Drawing.Point(16, 29);
            this.cbxPrinters.Name = "cbxPrinters";
            this.cbxPrinters.Size = new System.Drawing.Size(471, 21);
            this.cbxPrinters.TabIndex = 0;
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.BackgroundImage = global::PromodaIntegra.Properties.Resources.e_dgb;
            this.pnlPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrint.Controls.Add(this.lblComposition);
            this.pnlPrint.Controls.Add(this.lblBarCode);
            this.pnlPrint.Controls.Add(this.lblDescription);
            this.pnlPrint.Controls.Add(this.lblDestination);
            this.pnlPrint.Controls.Add(this.lblOrigin);
            this.pnlPrint.Controls.Add(this.lblArticle);
            this.pnlPrint.Controls.Add(this.lblWidth);
            this.pnlPrint.Controls.Add(this.lblPoNumber);
            this.pnlPrint.Controls.Add(this.lblColor);
            this.pnlPrint.Controls.Add(this.lblCnpj);
            this.pnlPrint.Controls.Add(this.lblWeight);
            this.pnlPrint.Controls.Add(this.lblMeters);
            this.pnlPrint.Controls.Add(this.lblLotRoll);
            this.pnlPrint.Controls.Add(this.lblNetWeight);
            this.pnlPrint.Location = new System.Drawing.Point(16, 56);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(396, 283);
            this.pnlPrint.TabIndex = 1;
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposition.Location = new System.Drawing.Point(2, 189);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(58, 15);
            this.lblComposition.TabIndex = 14;
            this.lblComposition.Text = "Composition";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(269, 159);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(51, 15);
            this.lblDestination.TabIndex = 13;
            this.lblDestination.Text = "Destination";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(136, 159);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(31, 15);
            this.lblOrigin.TabIndex = 12;
            this.lblOrigin.Text = "Origin";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(3, 159);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(26, 15);
            this.lblCnpj.TabIndex = 11;
            this.lblCnpj.Text = "Cnpj";
            // 
            // lblLotRoll
            // 
            this.lblLotRoll.AutoSize = true;
            this.lblLotRoll.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotRoll.Location = new System.Drawing.Point(269, 125);
            this.lblLotRoll.Name = "lblLotRoll";
            this.lblLotRoll.Size = new System.Drawing.Size(38, 15);
            this.lblLotRoll.TabIndex = 10;
            this.lblLotRoll.Text = "Lot-Roll";
            // 
            // lblNetWeight
            // 
            this.lblNetWeight.AutoSize = true;
            this.lblNetWeight.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeight.Location = new System.Drawing.Point(136, 125);
            this.lblNetWeight.Name = "lblNetWeight";
            this.lblNetWeight.Size = new System.Drawing.Size(48, 15);
            this.lblNetWeight.TabIndex = 9;
            this.lblNetWeight.Text = "NetWeight";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeters.Location = new System.Drawing.Point(3, 125);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(35, 15);
            this.lblMeters.TabIndex = 8;
            this.lblMeters.Text = "Meters";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(269, 94);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(34, 15);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Weight";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(136, 94);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(29, 15);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // lblPoNumber
            // 
            this.lblPoNumber.AutoSize = true;
            this.lblPoNumber.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoNumber.Location = new System.Drawing.Point(3, 94);
            this.lblPoNumber.Name = "lblPoNumber";
            this.lblPoNumber.Size = new System.Drawing.Size(59, 15);
            this.lblPoNumber.TabIndex = 5;
            this.lblPoNumber.Text = "P.O.Number";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(268, 61);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(29, 15);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.Location = new System.Drawing.Point(136, 61);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(32, 15);
            this.lblArticle.TabIndex = 3;
            this.lblArticle.Text = "Article";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(2, 61);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(52, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarCode.Location = new System.Drawing.Point(60, 16);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(52, 15);
            this.lblBarCode.TabIndex = 1;
            this.lblBarCode.Text = "lblBarCode";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(493, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(123, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblPrintersList
            // 
            this.lblPrintersList.AutoSize = true;
            this.lblPrintersList.Location = new System.Drawing.Point(16, 10);
            this.lblPrintersList.Name = "lblPrintersList";
            this.lblPrintersList.Size = new System.Drawing.Size(70, 13);
            this.lblPrintersList.TabIndex = 3;
            this.lblPrintersList.Text = "Select Printer";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // FrmDirectPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 480);
            this.Controls.Add(this.lblPrintersList);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.cbxPrinters);
            this.Name = "FrmDirectPrint";
            this.Text = "DirectPrint";
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPrinters;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblPrintersList;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPoNumber;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblLotRoll;
        private System.Windows.Forms.Label lblNetWeight;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}