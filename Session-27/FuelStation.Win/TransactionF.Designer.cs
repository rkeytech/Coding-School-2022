namespace FuelStation.Win
{
    partial class TransactionF
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
            this.components = new System.ComponentModel.Container();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.grdTransactionLines = new System.Windows.Forms.DataGridView();
            this.btnCancelTransaction = new System.Windows.Forms.Button();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlTransactionTotalValue = new System.Windows.Forms.NumericUpDown();
            this.ctrlTransactionEmployee = new System.Windows.Forms.ComboBox();
            this.lblTransactionTotalValue = new System.Windows.Forms.Label();
            this.lblTransactionPaymentMethod = new System.Windows.Forms.Label();
            this.ctrlTransactionCardNumber = new System.Windows.Forms.TextBox();
            this.lblTransactionEmployee = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblTransactionCardNumber = new System.Windows.Forms.Label();
            this.ctrlTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.ctrlTransactionCustomer = new System.Windows.Forms.TextBox();
            this.lblTransactionCustomer = new System.Windows.Forms.Label();
            this.ctrlPaymentMethod = new System.Windows.Forms.ComboBox();
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTransactionTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTransactionLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTransactionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 248);
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RowTemplate.Height = 25;
            this.grdTransactionLines.Size = new System.Drawing.Size(660, 276);
            this.grdTransactionLines.TabIndex = 0;
            // 
            // btnCancelTransaction
            // 
            this.btnCancelTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelTransaction.Location = new System.Drawing.Point(345, 530);
            this.btnCancelTransaction.Name = "btnCancelTransaction";
            this.btnCancelTransaction.Size = new System.Drawing.Size(136, 23);
            this.btnCancelTransaction.TabIndex = 9;
            this.btnCancelTransaction.Text = "Cancel";
            this.btnCancelTransaction.UseVisualStyleBackColor = true;
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTransaction.Location = new System.Drawing.Point(203, 530);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(136, 23);
            this.btnSaveTransaction.TabIndex = 8;
            this.btnSaveTransaction.Text = "Save";
            this.btnSaveTransaction.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Transaction Line";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlTransactionTotalValue
            // 
            this.ctrlTransactionTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTransactionTotalValue.Location = new System.Drawing.Point(444, 129);
            this.ctrlTransactionTotalValue.Name = "ctrlTransactionTotalValue";
            this.ctrlTransactionTotalValue.ReadOnly = true;
            this.ctrlTransactionTotalValue.Size = new System.Drawing.Size(200, 23);
            this.ctrlTransactionTotalValue.TabIndex = 32;
            // 
            // ctrlTransactionEmployee
            // 
            this.ctrlTransactionEmployee.FormattingEnabled = true;
            this.ctrlTransactionEmployee.Location = new System.Drawing.Point(89, 130);
            this.ctrlTransactionEmployee.Name = "ctrlTransactionEmployee";
            this.ctrlTransactionEmployee.Size = new System.Drawing.Size(200, 23);
            this.ctrlTransactionEmployee.TabIndex = 30;
            // 
            // lblTransactionTotalValue
            // 
            this.lblTransactionTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionTotalValue.AutoSize = true;
            this.lblTransactionTotalValue.Location = new System.Drawing.Point(375, 131);
            this.lblTransactionTotalValue.Name = "lblTransactionTotalValue";
            this.lblTransactionTotalValue.Size = new System.Drawing.Size(63, 15);
            this.lblTransactionTotalValue.TabIndex = 29;
            this.lblTransactionTotalValue.Text = "Total Value";
            // 
            // lblTransactionPaymentMethod
            // 
            this.lblTransactionPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionPaymentMethod.AutoSize = true;
            this.lblTransactionPaymentMethod.Location = new System.Drawing.Point(339, 92);
            this.lblTransactionPaymentMethod.Name = "lblTransactionPaymentMethod";
            this.lblTransactionPaymentMethod.Size = new System.Drawing.Size(99, 15);
            this.lblTransactionPaymentMethod.TabIndex = 28;
            this.lblTransactionPaymentMethod.Text = "Payment Method";
            // 
            // ctrlTransactionCardNumber
            // 
            this.ctrlTransactionCardNumber.Location = new System.Drawing.Point(89, 50);
            this.ctrlTransactionCardNumber.Name = "ctrlTransactionCardNumber";
            this.ctrlTransactionCardNumber.Size = new System.Drawing.Size(200, 23);
            this.ctrlTransactionCardNumber.TabIndex = 26;
            // 
            // lblTransactionEmployee
            // 
            this.lblTransactionEmployee.AutoSize = true;
            this.lblTransactionEmployee.Location = new System.Drawing.Point(24, 133);
            this.lblTransactionEmployee.Name = "lblTransactionEmployee";
            this.lblTransactionEmployee.Size = new System.Drawing.Size(59, 15);
            this.lblTransactionEmployee.TabIndex = 25;
            this.lblTransactionEmployee.Text = "Employee";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(52, 20);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(31, 15);
            this.lblTransactionDate.TabIndex = 24;
            this.lblTransactionDate.Text = "Date";
            // 
            // lblTransactionCardNumber
            // 
            this.lblTransactionCardNumber.AutoSize = true;
            this.lblTransactionCardNumber.Location = new System.Drawing.Point(4, 53);
            this.lblTransactionCardNumber.Name = "lblTransactionCardNumber";
            this.lblTransactionCardNumber.Size = new System.Drawing.Size(79, 15);
            this.lblTransactionCardNumber.TabIndex = 23;
            this.lblTransactionCardNumber.Text = "Card Number";
            // 
            // ctrlTransactionDate
            // 
            this.ctrlTransactionDate.Location = new System.Drawing.Point(89, 14);
            this.ctrlTransactionDate.Name = "ctrlTransactionDate";
            this.ctrlTransactionDate.Size = new System.Drawing.Size(200, 23);
            this.ctrlTransactionDate.TabIndex = 33;
            // 
            // ctrlTransactionCustomer
            // 
            this.ctrlTransactionCustomer.Location = new System.Drawing.Point(89, 89);
            this.ctrlTransactionCustomer.Name = "ctrlTransactionCustomer";
            this.ctrlTransactionCustomer.ReadOnly = true;
            this.ctrlTransactionCustomer.Size = new System.Drawing.Size(200, 23);
            this.ctrlTransactionCustomer.TabIndex = 35;
            // 
            // lblTransactionCustomer
            // 
            this.lblTransactionCustomer.AutoSize = true;
            this.lblTransactionCustomer.Location = new System.Drawing.Point(24, 92);
            this.lblTransactionCustomer.Name = "lblTransactionCustomer";
            this.lblTransactionCustomer.Size = new System.Drawing.Size(59, 15);
            this.lblTransactionCustomer.TabIndex = 34;
            this.lblTransactionCustomer.Text = "Customer";
            // 
            // ctrlPaymentMethod
            // 
            this.ctrlPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPaymentMethod.FormattingEnabled = true;
            this.ctrlPaymentMethod.Location = new System.Drawing.Point(444, 89);
            this.ctrlPaymentMethod.Name = "ctrlPaymentMethod";
            this.ctrlPaymentMethod.Size = new System.Drawing.Size(200, 23);
            this.ctrlPaymentMethod.TabIndex = 36;
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ctrlPaymentMethod);
            this.Controls.Add(this.ctrlTransactionCustomer);
            this.Controls.Add(this.lblTransactionCustomer);
            this.Controls.Add(this.ctrlTransactionDate);
            this.Controls.Add(this.ctrlTransactionTotalValue);
            this.Controls.Add(this.ctrlTransactionEmployee);
            this.Controls.Add(this.lblTransactionTotalValue);
            this.Controls.Add(this.lblTransactionPaymentMethod);
            this.Controls.Add(this.ctrlTransactionCardNumber);
            this.Controls.Add(this.lblTransactionEmployee);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblTransactionCardNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelTransaction);
            this.Controls.Add(this.btnSaveTransaction);
            this.Controls.Add(this.grdTransactionLines);
            this.Name = "TransactionF";
            this.Text = "TransactionF";
            this.Load += new System.EventHandler(this.TransactionF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTransactionTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bsTransaction;
        private DataGridView grdTransactionLines;
        private Button btnCancelTransaction;
        private Button btnSaveTransaction;
        private Button button1;
        private NumericUpDown ctrlTransactionTotalValue;
        private ComboBox ctrlTransactionEmployee;
        private Label lblTransactionTotalValue;
        private Label lblTransactionPaymentMethod;
        private TextBox ctrlTransactionCardNumber;
        private Label lblTransactionEmployee;
        private Label lblTransactionDate;
        private Label lblTransactionCardNumber;
        private DateTimePicker ctrlTransactionDate;
        private TextBox ctrlTransactionCustomer;
        private Label lblTransactionCustomer;
        private ComboBox ctrlPaymentMethod;
        private BindingSource bsTransactionLines;
    }
}