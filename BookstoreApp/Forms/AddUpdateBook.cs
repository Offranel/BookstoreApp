using BookstoreApp.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace BookstoreApp
{
    public partial class AddUpdateBook : Form
    {
        private Book? _book;
        private bool _isUpdate;

        public Book Book { get; private set; }

        private void SetupForm()
        {
            this.Text = _isUpdate ? "Update Book" : "Add Book";
            txtTitle = new TextBox { Left = 20, Top = 20, Width = 200, Text = string.Empty, PlaceholderText = "Title" };
            txtPrice = new TextBox { Left = 20, Top = 60, Width = 200, Text = string.Empty, PlaceholderText = "Price" };
            txtISBN = new TextBox { Left = 20, Top = 100, Width = 200, Text = string.Empty, PlaceholderText = "ISBN" };

            if (_book != null)
            {
                txtTitle.Text = _book.Title;
                txtPrice.Text = _book.Price.ToString();
                txtISBN.Text = _book.ISBN;
            }
                    }
        public AddUpdateBook(Book? book = null)
        {
            InitializeComponent();

            _isUpdate = book != null;
            _book = book;

            

            if (_book != null)
            {
                Book = new Book
               {
                    Id = _book.Id,
                    Title = _book.Title,
                    Price = _book.Price,
                    ISBN = _book.ISBN
                };

               txtTitle.Text = Book.Title;
                txtPrice.Text =
                  Book.Price.ToString(CultureInfo.InvariantCulture);
                txtISBN.Text = Book.ISBN;
            }
            else
            {
                Book = new Book
                {
                    Title = "",
                    Price = 0,
                    ISBN = txtISBN.Text,
                };
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text?.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(
                    "Title is required",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!double.TryParse(
                txtPrice.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out var price))
            {
                MessageBox.Show(
                    "Price must be a valid number",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var isbn = txtISBN.Text?.Trim();

            if (string.IsNullOrEmpty(isbn) || isbn.Length != 13 || !ulong.TryParse(isbn, out _))
            {
                MessageBox.Show(
                    "ISBN is required and must be 13 digits (no dashes)",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Book.Title = title;
            Book.Price = price;
            Book.ISBN = isbn!;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}