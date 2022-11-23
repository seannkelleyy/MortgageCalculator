namespace MortgageCalculatorApplication
{
    partial class Form1
    {
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
            this.resetButton = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.mortgageAmortization = new System.Windows.Forms.DataGridView();
            this.PaymentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPaymentAmountLabel = new System.Windows.Forms.Label();
            this.paymentAmountLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mortgageAmortization)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(198, 317);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(62, 33);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(156, 270);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(17, 15);
            this.percentLabel.TabIndex = 28;
            this.percentLabel.Text = "%";
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(39, 130);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(13, 15);
            this.dollarLabel.TabIndex = 27;
            this.dollarLabel.Text = "$";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(156, 201);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(34, 15);
            this.yearsLabel.TabIndex = 26;
            this.yearsLabel.Text = "years";
            // 
            // mortgageAmortization
            // 
            this.mortgageAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mortgageAmortization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentNumber,
            this.BeginningBalance,
            this.PaymentAmount,
            this.Principal,
            this.Interest,
            this.InterestPaid,
            this.EndingBalance});
            this.mortgageAmortization.Location = new System.Drawing.Point(266, 105);
            this.mortgageAmortization.Name = "mortgageAmortization";
            this.mortgageAmortization.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mortgageAmortization.RowTemplate.Height = 25;
            this.mortgageAmortization.Size = new System.Drawing.Size(503, 298);
            this.mortgageAmortization.TabIndex = 25;
            // 
            // PaymentNumber
            // 
            this.PaymentNumber.HeaderText = "Payment Number";
            this.PaymentNumber.Name = "PaymentNumber";
            // 
            // BeginningBalance
            // 
            this.BeginningBalance.HeaderText = "Beginning Balance";
            this.BeginningBalance.Name = "BeginningBalance";
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.HeaderText = "Payment Amount";
            this.PaymentAmount.Name = "PaymentAmount";
            // 
            // Principal
            // 
            this.Principal.HeaderText = "Principal";
            this.Principal.Name = "Principal";
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            // 
            // InterestPaid
            // 
            this.InterestPaid.HeaderText = "Interest Paid";
            this.InterestPaid.Name = "InterestPaid";
            // 
            // EndingBalance
            // 
            this.EndingBalance.HeaderText = "Ending Balance";
            this.EndingBalance.Name = "EndingBalance";
            // 
            // monthlyPaymentAmountLabel
            // 
            this.monthlyPaymentAmountLabel.AutoSize = true;
            this.monthlyPaymentAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlyPaymentAmountLabel.Location = new System.Drawing.Point(91, 405);
            this.monthlyPaymentAmountLabel.Name = "monthlyPaymentAmountLabel";
            this.monthlyPaymentAmountLabel.Size = new System.Drawing.Size(0, 17);
            this.monthlyPaymentAmountLabel.TabIndex = 24;
            // 
            // paymentAmountLabel
            // 
            this.paymentAmountLabel.AutoSize = true;
            this.paymentAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmountLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.paymentAmountLabel.Location = new System.Drawing.Point(54, 373);
            this.paymentAmountLabel.Name = "paymentAmountLabel";
            this.paymentAmountLabel.Size = new System.Drawing.Size(135, 21);
            this.paymentAmountLabel.TabIndex = 23;
            this.paymentAmountLabel.Text = "Monthly Payment:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(54, 316);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(130, 34);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "Create Mortgage";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(58, 193);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 23);
            this.lengthTextBox.TabIndex = 21;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lengthLabel.Location = new System.Drawing.Point(58, 171);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(156, 19);
            this.lengthLabel.TabIndex = 20;
            this.lengthLabel.Text = "Enter Mortgage Length:";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(58, 265);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateTextBox.TabIndex = 19;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rateLabel.Location = new System.Drawing.Point(58, 243);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(126, 19);
            this.rateLabel.TabIndex = 18;
            this.rateLabel.Text = "Enter Interest Rate:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(58, 127);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 23);
            this.amountTextBox.TabIndex = 17;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.amountLabel.Location = new System.Drawing.Point(58, 105);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(163, 19);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Enter Mortgage Amount:";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titlelabel.Location = new System.Drawing.Point(31, 28);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(289, 30);
            this.titlelabel.TabIndex = 15;
            this.titlelabel.Text = "Mortgage Payment Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.mortgageAmortization);
            this.Controls.Add(this.monthlyPaymentAmountLabel);
            this.Controls.Add(this.paymentAmountLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "MortgageCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.mortgageAmortization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button resetButton;
        private Label percentLabel;
        private Label dollarLabel;
        private Label yearsLabel;
        private DataGridView mortgageAmortization;
        private DataGridViewTextBoxColumn PaymentNumber;
        private DataGridViewTextBoxColumn BeginningBalance;
        private DataGridViewTextBoxColumn PaymentAmount;
        private DataGridViewTextBoxColumn Principal;
        private DataGridViewTextBoxColumn Interest;
        private DataGridViewTextBoxColumn InterestPaid;
        private DataGridViewTextBoxColumn EndingBalance;
        private Label monthlyPaymentAmountLabel;
        private Label paymentAmountLabel;
        private Button submitButton;
        private TextBox lengthTextBox;
        private Label lengthLabel;
        private TextBox rateTextBox;
        private Label rateLabel;
        private TextBox amountTextBox;
        private Label amountLabel;
        private Label titlelabel;
    }
}