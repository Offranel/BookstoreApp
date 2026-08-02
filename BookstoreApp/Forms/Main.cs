using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreApp.Database;
using BookstoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }

        private async Task LoadBooksAsync()
        {
            using var db = new BookStoreDb();

            var books = await db.Books
                .OrderBy(b => b.Title)
                .ToListAsync();

            lstBooks.DataSource = books;
            lstBooks.DisplayMember = "Display";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new AddUpdateBook();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new BookStoreDb();

                // If the form supplied any genres, attach them as existing (unchanged)
                if (form.Book.Genres != null && form.Book.Genres.Count > 0)
                {
                    foreach (var genre in form.Book.Genres)
                    {
                        db.Genres.Attach(genre);
                    }
                }

                await db.Books.AddAsync(form.Book);
                await db.SaveChangesAsync();
                await LoadBooksAsync();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is not Book selected)
            {
                return;
            }

            using var db = new BookStoreDb();

            var book = await db.Books
                .Include(b => b.Genres)
                .FirstOrDefaultAsync(b => b.Id == selected.Id);

            if (book == null)
            {
                return;
            }

            using var form = new AddUpdateBook(book);

            if (form.ShowDialog() == DialogResult.OK)
            {
                book.Title = form.Book.Title;
                book.Price = form.Book.Price;
                book.ISBN = form.Book.ISBN;
                book.Description = form.Book.Description;

                // Replace existing genre links with the selected genres from the form.
                book.Genres.Clear();
                if (form.Book.Genres != null && form.Book.Genres.Count > 0)
                {
                    foreach (var g in form.Book.Genres)
                    {
                        // Ensure EF Core treats this genre as an existing entity
                        db.Genres.Attach(g);
                        book.Genres.Add(g);
                    }
                }

                await db.SaveChangesAsync();
                await LoadBooksAsync();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is not Book selected)
            {
                return;
            }

            var result = MessageBox.Show(
                $"Delete '{selected.Title}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using var db = new BookStoreDb();

            var book = await db.Books
                .FirstOrDefaultAsync(b => b.Id == selected.Id);

            if (book == null)
            {
                return;
            }

            db.Books.Remove(book);
            await db.SaveChangesAsync();

            await LoadBooksAsync();
        }
    }
}