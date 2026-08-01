namespace BookstoreApp
{
    partial class AddUpdateBook
    {
        private System.ComponentModel.IContainer? components = null;

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

            
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
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

            txtPrice.Location = new Point(120, 77);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 47);
            txtPrice.TabIndex = 3;

           
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(20, 140);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(62, 41);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN";

            
            txtISBN.Location = new Point(120, 137);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(300, 47);
            txtISBN.TabIndex = 5;

            
            btnOk.Location = new Point(230, 210);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(90, 50);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;

            btnCancel.Location = new Point(330, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 50);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 300);

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

            Name = "AddUpdateBook";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add / Update Book";

            ResumeLayout(false);
            PerformLayout();
        }

        
    }
}
