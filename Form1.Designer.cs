namespace _Software_Sales_
{
    partial class SoftwareSalesApplication
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
            this.packageTxt = new System.Windows.Forms.TextBox();
            this.discountLbl = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DiscountAmount = new System.Windows.Forms.Label();
            this.PurchaseTotalLabel = new System.Windows.Forms.Label();
            this.totalPurchaseLbl = new System.Windows.Forms.Label();
            this.CalculateTotal_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // packageTxt
            // 
            this.packageTxt.Location = new System.Drawing.Point(206, 35);
            this.packageTxt.Name = "packageTxt";
            this.packageTxt.Size = new System.Drawing.Size(190, 22);
            this.packageTxt.TabIndex = 1;
            // 
            // discountLbl
            // 
            this.discountLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountLbl.Location = new System.Drawing.Point(206, 79);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(190, 23);
            this.discountLbl.TabIndex = 3;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Location = new System.Drawing.Point(61, 38);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(139, 44);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Enter the quantity of software packages:";
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.Location = new System.Drawing.Point(73, 79);
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Size = new System.Drawing.Size(127, 23);
            this.DiscountAmount.TabIndex = 5;
            this.DiscountAmount.Text = "Discount Amount:";
            // 
            // PurchaseTotalLabel
            // 
            this.PurchaseTotalLabel.Location = new System.Drawing.Point(83, 123);
            this.PurchaseTotalLabel.Name = "PurchaseTotalLabel";
            this.PurchaseTotalLabel.Size = new System.Drawing.Size(117, 23);
            this.PurchaseTotalLabel.TabIndex = 6;
            this.PurchaseTotalLabel.Text = "Purchase Total:";
            // 
            // totalPurchaseLbl
            // 
            this.totalPurchaseLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPurchaseLbl.Location = new System.Drawing.Point(206, 123);
            this.totalPurchaseLbl.Name = "totalPurchaseLbl";
            this.totalPurchaseLbl.Size = new System.Drawing.Size(190, 23);
            this.totalPurchaseLbl.TabIndex = 7;
            // 
            // CalculateTotal_btn
            // 
            this.CalculateTotal_btn.Location = new System.Drawing.Point(56, 181);
            this.CalculateTotal_btn.Name = "CalculateTotal_btn";
            this.CalculateTotal_btn.Size = new System.Drawing.Size(84, 43);
            this.CalculateTotal_btn.TabIndex = 8;
            this.CalculateTotal_btn.Text = "Calculate Total";
            this.CalculateTotal_btn.UseVisualStyleBackColor = true;
            this.CalculateTotal_btn.Click += new System.EventHandler(this.CalculateTotal_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(184, 181);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(84, 43);
            this.Clear_btn.TabIndex = 9;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(312, 181);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(84, 43);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // SoftwareSalesApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 253);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.CalculateTotal_btn);
            this.Controls.Add(this.totalPurchaseLbl);
            this.Controls.Add(this.PurchaseTotalLabel);
            this.Controls.Add(this.DiscountAmount);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.packageTxt);
            this.Name = "SoftwareSalesApplication";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox packageTxt;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label DiscountAmount;
        private System.Windows.Forms.Label PurchaseTotalLabel;
        private System.Windows.Forms.Label totalPurchaseLbl;
        private System.Windows.Forms.Button CalculateTotal_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}

