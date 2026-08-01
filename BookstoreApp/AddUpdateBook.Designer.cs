namespace BookstoreApp
{
    partial class AddUpdateBook
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtISBN = new TextBox();
            lblTitle = new Label();
            lblPrice = new Label();
            lblISBN = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(70, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 47);
            txtTitle.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(70, 52);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 47);
            txtPrice.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(70, 100);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(200, 47);
            txtISBN.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(74, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 55);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(82, 41);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(12, 103);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(62, 41);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(214, 100);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 54);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(295, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 54);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 434);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
