namespace BudgetReport
{
    partial class BudgetReportForm
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
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.EstimateLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.EstimateTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.DateILabel = new System.Windows.Forms.Label();
            this.DateITextM = new System.Windows.Forms.TextBox();
            this.DateITextD = new System.Windows.Forms.TextBox();
            this.DateITextY = new System.Windows.Forms.TextBox();
            this.DateFLabel = new System.Windows.Forms.Label();
            this.DateFTextM = new System.Windows.Forms.TextBox();
            this.DateFTextD = new System.Windows.Forms.TextBox();
            this.DateFTextY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Location = new System.Drawing.Point(13, 13);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(211, 13);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Budget Report will reference data stored in:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(16, 66);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // EstimateLabel
            // 
            this.EstimateLabel.AutoSize = true;
            this.EstimateLabel.Location = new System.Drawing.Point(16, 88);
            this.EstimateLabel.Name = "EstimateLabel";
            this.EstimateLabel.Size = new System.Drawing.Size(86, 13);
            this.EstimateLabel.TabIndex = 2;
            this.EstimateLabel.Text = "Target Spending";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(115, 59);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // EstimateTextBox
            // 
            this.EstimateTextBox.Location = new System.Drawing.Point(115, 85);
            this.EstimateTextBox.Name = "EstimateTextBox";
            this.EstimateTextBox.Size = new System.Drawing.Size(100, 20);
            this.EstimateTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(16, 30);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(0, 13);
            this.AddressLabel.TabIndex = 5;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(115, 158);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 2;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            // 
            // DateILabel
            // 
            this.DateILabel.AutoSize = true;
            this.DateILabel.Location = new System.Drawing.Point(16, 112);
            this.DateILabel.Name = "DateILabel";
            this.DateILabel.Size = new System.Drawing.Size(55, 13);
            this.DateILabel.TabIndex = 7;
            this.DateILabel.Text = "Start Date";
            // 
            // DateITextM
            // 
            this.DateITextM.Location = new System.Drawing.Point(115, 109);
            this.DateITextM.Name = "DateITextM";
            this.DateITextM.Size = new System.Drawing.Size(22, 20);
            this.DateITextM.TabIndex = 5;
            // 
            // DateITextD
            // 
            this.DateITextD.Location = new System.Drawing.Point(143, 109);
            this.DateITextD.Name = "DateITextD";
            this.DateITextD.Size = new System.Drawing.Size(21, 20);
            this.DateITextD.TabIndex = 6;
            // 
            // DateITextY
            // 
            this.DateITextY.Location = new System.Drawing.Point(169, 109);
            this.DateITextY.Name = "DateITextY";
            this.DateITextY.Size = new System.Drawing.Size(46, 20);
            this.DateITextY.TabIndex = 7;
            // 
            // DateFLabel
            // 
            this.DateFLabel.AutoSize = true;
            this.DateFLabel.Location = new System.Drawing.Point(16, 135);
            this.DateFLabel.Name = "DateFLabel";
            this.DateFLabel.Size = new System.Drawing.Size(52, 13);
            this.DateFLabel.TabIndex = 11;
            this.DateFLabel.Text = "End Date";
            // 
            // DateFTextM
            // 
            this.DateFTextM.Location = new System.Drawing.Point(115, 132);
            this.DateFTextM.Name = "DateFTextM";
            this.DateFTextM.Size = new System.Drawing.Size(22, 20);
            this.DateFTextM.TabIndex = 8;
            // 
            // DateFTextD
            // 
            this.DateFTextD.Location = new System.Drawing.Point(143, 132);
            this.DateFTextD.Name = "DateFTextD";
            this.DateFTextD.Size = new System.Drawing.Size(21, 20);
            this.DateFTextD.TabIndex = 9;
            // 
            // DateFTextY
            // 
            this.DateFTextY.Location = new System.Drawing.Point(169, 132);
            this.DateFTextY.Name = "DateFTextY";
            this.DateFTextY.Size = new System.Drawing.Size(46, 20);
            this.DateFTextY.TabIndex = 10;
            // 
            // BudgetReportForm
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 200);
            this.Controls.Add(this.DateFTextY);
            this.Controls.Add(this.DateFTextD);
            this.Controls.Add(this.DateFTextM);
            this.Controls.Add(this.DateFLabel);
            this.Controls.Add(this.DateITextY);
            this.Controls.Add(this.DateITextD);
            this.Controls.Add(this.DateITextM);
            this.Controls.Add(this.DateILabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EstimateTextBox);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.EstimateLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NotificationLabel);
            this.Name = "BudgetReportForm";
            this.Text = "Budget Report 1.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label EstimateLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox EstimateTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label DateILabel;
        private System.Windows.Forms.TextBox DateITextM;
        private System.Windows.Forms.TextBox DateITextD;
        private System.Windows.Forms.TextBox DateITextY;
        private System.Windows.Forms.Label DateFLabel;
        private System.Windows.Forms.TextBox DateFTextM;
        private System.Windows.Forms.TextBox DateFTextD;
        private System.Windows.Forms.TextBox DateFTextY;
    }
}

