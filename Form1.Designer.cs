namespace MTJeremiahMacDougall
{
    partial class FormMidTermExam
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
            this.btnShowAllTools = new System.Windows.Forms.Button();
            this.btnSortByPartDesc = new System.Windows.Forms.Button();
            this.btnSortByPrice = new System.Windows.Forms.Button();
            this.btnQtyRange10And40 = new System.Windows.Forms.Button();
            this.btnWherePartNo = new System.Windows.Forms.Button();
            this.numUserSelection = new System.Windows.Forms.NumericUpDown();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRowsFetched = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUserSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllTools
            // 
            this.btnShowAllTools.Location = new System.Drawing.Point(39, 43);
            this.btnShowAllTools.Name = "btnShowAllTools";
            this.btnShowAllTools.Size = new System.Drawing.Size(103, 78);
            this.btnShowAllTools.TabIndex = 1;
            this.btnShowAllTools.Text = "Show All Tools";
            this.btnShowAllTools.UseVisualStyleBackColor = true;
            this.btnShowAllTools.Click += new System.EventHandler(this.btnShowAllTools_Click);
            // 
            // btnSortByPartDesc
            // 
            this.btnSortByPartDesc.Location = new System.Drawing.Point(148, 43);
            this.btnSortByPartDesc.Name = "btnSortByPartDesc";
            this.btnSortByPartDesc.Size = new System.Drawing.Size(112, 78);
            this.btnSortByPartDesc.TabIndex = 2;
            this.btnSortByPartDesc.Text = "Sort by Part Description";
            this.btnSortByPartDesc.UseVisualStyleBackColor = true;
            this.btnSortByPartDesc.Click += new System.EventHandler(this.btnSortByPartDesc_Click);
            // 
            // btnSortByPrice
            // 
            this.btnSortByPrice.Location = new System.Drawing.Point(266, 43);
            this.btnSortByPrice.Name = "btnSortByPrice";
            this.btnSortByPrice.Size = new System.Drawing.Size(121, 78);
            this.btnSortByPrice.TabIndex = 3;
            this.btnSortByPrice.Text = "Sort by Price";
            this.btnSortByPrice.UseVisualStyleBackColor = true;
            this.btnSortByPrice.Click += new System.EventHandler(this.btnSortByPrice_Click);
            // 
            // btnQtyRange10And40
            // 
            this.btnQtyRange10And40.Location = new System.Drawing.Point(393, 43);
            this.btnQtyRange10And40.Name = "btnQtyRange10And40";
            this.btnQtyRange10And40.Size = new System.Drawing.Size(142, 78);
            this.btnQtyRange10And40.TabIndex = 4;
            this.btnQtyRange10And40.Text = "Quantity range 10 and 40";
            this.btnQtyRange10And40.UseVisualStyleBackColor = true;
            this.btnQtyRange10And40.Click += new System.EventHandler(this.btnQtyRange10And40_Click);
            // 
            // btnWherePartNo
            // 
            this.btnWherePartNo.Location = new System.Drawing.Point(632, 43);
            this.btnWherePartNo.Name = "btnWherePartNo";
            this.btnWherePartNo.Size = new System.Drawing.Size(142, 78);
            this.btnWherePartNo.TabIndex = 5;
            this.btnWherePartNo.Text = "Where Part Number =";
            this.btnWherePartNo.UseVisualStyleBackColor = true;
            this.btnWherePartNo.Click += new System.EventHandler(this.btnWherePartNo_Click);
            // 
            // numUserSelection
            // 
            this.numUserSelection.Location = new System.Drawing.Point(795, 70);
            this.numUserSelection.Name = "numUserSelection";
            this.numUserSelection.Size = new System.Drawing.Size(103, 26);
            this.numUserSelection.TabIndex = 6;
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.BackColor = System.Drawing.Color.White;
            this.lblPartNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartNumber.Location = new System.Drawing.Point(39, 195);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(103, 256);
            this.lblPartNumber.TabIndex = 2;
            this.lblPartNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(148, 195);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(387, 256);
            this.lblDescription.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.White;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Location = new System.Drawing.Point(546, 195);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(107, 256);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(671, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(103, 256);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.BackColor = System.Drawing.Color.White;
            this.lblInvoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceTotal.Location = new System.Drawing.Point(797, 195);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(103, 256);
            this.lblInvoiceTotal.TabIndex = 2;
            this.lblInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(795, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRowsFetched
            // 
            this.lblRowsFetched.AutoSize = true;
            this.lblRowsFetched.Location = new System.Drawing.Point(46, 503);
            this.lblRowsFetched.Name = "lblRowsFetched";
            this.lblRowsFetched.Size = new System.Drawing.Size(68, 20);
            this.lblRowsFetched.TabIndex = 4;
            this.lblRowsFetched.Text = "Fetched";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Part Number";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(148, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Part Description";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(557, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(678, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(803, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "Invoice Total";
            // 
            // FormMidTermExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(964, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRowsFetched);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.numUserSelection);
            this.Controls.Add(this.btnWherePartNo);
            this.Controls.Add(this.btnQtyRange10And40);
            this.Controls.Add(this.btnSortByPrice);
            this.Controls.Add(this.btnSortByPartDesc);
            this.Controls.Add(this.btnShowAllTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMidTermExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mid-Term Exam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMidTermExam_FormClosing);
            this.Load += new System.EventHandler(this.FormMidTermExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUserSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllTools;
        private System.Windows.Forms.Button btnSortByPartDesc;
        private System.Windows.Forms.Button btnSortByPrice;
        private System.Windows.Forms.Button btnQtyRange10And40;
        private System.Windows.Forms.Button btnWherePartNo;
        private System.Windows.Forms.NumericUpDown numUserSelection;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRowsFetched;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

