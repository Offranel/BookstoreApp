using BookstoreApp.Models;
using BookstoreApp.Database;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

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
            txtDescription = new TextBox { Left = 20, Top = 160, Width = 300, Height = 80, Text = string.Empty, Multiline = true };
            clbGenres = new CheckedListBox { Left = 20, Top = 260, Width = 250, Height = 120, CheckOnClick = true };

            if (_book != null)
            {
                txtTitle.Text = _book.Title;
                txtPrice.Text = _book.Price.ToString();
                txtISBN.Text = _book.ISBN;
                txtDescription.Text = _book.Description ?? string.Empty;
                if (_book.Genres != null && _book.Genres.Count > 0)
                {
                    // select first genre if present; actual selection will be applied after data binding
                }
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
                txtDescription.Text = _book.Description ?? string.Empty;
            }
            else
            {
                Book = new Book
                {
                    Title = "",
                    Price = 0,
                    ISBN = txtISBN.Text,
                    Description = string.Empty,
                    Genres = new List<Genre>()
                };
            }

            // Load genres into checked list
            try
            {
                using var db = new BookStoreDb();
                var genres = db.Genres.OrderBy(g => g.Name).ToList();
                // populate checkedlist with Genre objects and mark checked if the book has them
                clbGenres.Items.Clear();
                foreach (var g in genres)
                {
                    var isChecked = _book != null && _book.Genres != null && _book.Genres.Any(bg => bg.GenreId == g.GenreId);
                    clbGenres.Items.Add(g, isChecked);
                }
            }
            catch
            {
                // ignore DB errors; combobox will remain empty
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
            Book.Description = txtDescription.Text?.Trim();

            // Assign selected genres from checked list
            var selected = new List<Genre>();
            if (clbGenres != null)
            {
                foreach (var item in clbGenres.CheckedItems)
                {
                    if (item is Genre g) selected.Add(g);
                }
            }

            Book.Genres = selected;

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