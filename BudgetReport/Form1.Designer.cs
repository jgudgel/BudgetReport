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
            this.EstimateLabel.Location = new System.Drawing.Point(16, 92);
            this.EstimateLabel.Name = "EstimateLabel";
            this.EstimateLabel.Size = new System.Drawing.Size(87, 13);
            this.EstimateLabel.TabIndex = 2;
            this.EstimateLabel.Text = "Monthly Estimate";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(115, 58);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // EstimateTextBox
            // 
            this.EstimateTextBox.Location = new System.Drawing.Point(115, 84);
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
            this.CalcButton.Location = new System.Drawing.Point(78, 119);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            // 
            // BudgetReportForm
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 156);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EstimateTextBox);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.EstimateLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NotificationLabel);
            this.Name = "BudgetReportForm";
            this.Text = "Budget Report 1.0";
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
    }
}

