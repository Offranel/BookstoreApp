namespace BookstoreApp
{
    partial class AddUpdateBook
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbGenres;

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
            txtDescription = new TextBox();
            cmbGenres = new ComboBox();

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
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 47);
            txtTitle.TabIndex = 1;

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

            // 
            // lblDescription
            // 
            var lblDescription = new Label();
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 190);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(120, 41);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";

            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 187);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 80);
            txtDescription.TabIndex = 7;
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;

            // 
            // lblGenre
            // 
            var lblGenre = new Label();
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(20, 280);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(74, 41);
            lblGenre.TabIndex = 8;
            lblGenre.Text = "Genre";

            // 
            // cmbGenres
            // 
            cmbGenres.Location = new Point(120, 277);
            cmbGenres.Name = "cmbGenres";
            cmbGenres.Size = new Size(250, 47);
            cmbGenres.TabIndex = 9;
            cmbGenres.DropDownStyle = ComboBoxStyle.DropDownList;

            
            btnOk.Location = new Point(120, 360);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(300, 45);
            btnOk.TabIndex = 10;
            btnOk.Text = "save";
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
            ClientSize = new Size(460, 420);

            Controls.Add(lblTitle);
            Controls.Add(txtTitle);

            Controls.Add(lblPrice);
            Controls.Add(txtPrice);

            Controls.Add(lblISBN);
            Controls.Add(txtISBN);

            Controls.Add(lblDescription);
            Controls.Add(txtDescription);

            Controls.Add(lblGenre);
            Controls.Add(cmbGenres);

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
