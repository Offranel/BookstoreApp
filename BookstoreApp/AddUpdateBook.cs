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

            if (_book != null)
            {
                txtTitle.Text = _book.Title;
                txtPrice.Text = _book.Price.ToString();
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
                    Price = _book.Price
                };

                txtTitle.Text = Book.Title;
                txtPrice.Text =
                    Book.Price.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                Book = new Book
                {
                    Title = ""
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

            Book.Title = title;
            Book.Price = price;

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