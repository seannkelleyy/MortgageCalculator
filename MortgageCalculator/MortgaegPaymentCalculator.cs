namespace MortgageCalculator
{
    partial class Form1
    {
        private Label titleLabel;
        private Label amountLabel;
        private TextBox amountTextBox;
        private TextBox lengthTextBox;
        private Label lengthLabel;
        private TextBox rateTextBox;
        private Label rateLabel;
        private Label label1;
        private Label paymentAmountLabel;
        private Label paymentLabel;
        private Button submitButton;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentAmountLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.titleLabel.Location = new System.Drawing.Point(24, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(331, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Mortgage Payment Calculator";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.ForeColor = System.Drawing.Color.Navy;
            this.amountLabel.Location = new System.Drawing.Point(33, 92);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(139, 15);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Enter Mortgage Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(33, 122);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 23);
            this.amountTextBox.TabIndex = 2;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(33, 212);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 23);
            this.lengthTextBox.TabIndex = 4;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.ForeColor = System.Drawing.Color.Navy;
            this.lengthLabel.Location = new System.Drawing.Point(33, 182);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(132, 15);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Enter Mortgage Length:";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(33, 300);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateTextBox.TabIndex = 6;
            this.rateTextBox.Text = "ex: 5.0";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.ForeColor = System.Drawing.Color.Navy;
            this.rateLabel.Location = new System.Drawing.Point(33, 269);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(105, 15);
            this.rateLabel.TabIndex = 5;
            this.rateLabel.Text = "Enter Interest Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // paymentAmountLabel
            // 
            this.paymentAmountLabel.AutoSize = true;
            this.paymentAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmountLabel.ForeColor = System.Drawing.Color.Navy;
            this.paymentAmountLabel.Location = new System.Drawing.Point(364, 71);
            this.paymentAmountLabel.Name = "paymentAmountLabel";
            this.paymentAmountLabel.Size = new System.Drawing.Size(124, 19);
            this.paymentAmountLabel.TabIndex = 8;
            this.paymentAmountLabel.Text = "Payment Amount: ";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.paymentLabel.Location = new System.Drawing.Point(33, 393);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(0, 17);
            this.paymentLabel.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(33, 353);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(91, 29);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.paymentAmountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "MortgagePaymentCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}