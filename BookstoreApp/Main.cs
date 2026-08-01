using System.Linq;
using System.Windows.Forms;
using BookstoreApp.Database;
namespace BookstoreApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            using var db = new BookStoreDb();
            var books = db.Books.OrderBy(b => b.Title).ToList();
            lstBooks.DataSource = books;
            lstBooks.DisplayMember = "Title";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new AddUpdateBook();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new BookStoreDb();
                db.Books.Add(form.Book);
                db.SaveChanges();
                LoadBooks();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is not Book selected) return;

            using var db = new BookStoreDb();
            var book = db.Books.FirstOrDefault(b => b.Id == selected.Id);
            if (book == null) return;

            using var form = new AddUpdateBook(book);
            if (form.ShowDialog() == DialogResult.OK)
            {
                book.Title = form.Book.Title;
                book.Price = form.Book.Price;
                db.SaveChanges();
                LoadBooks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is not Book selected) return;

            var result = MessageBox.Show($"Delete '{selected.Title}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using var db = new BookStoreDb();
            var book = db.Books.FirstOrDefault(b => b.Id == selected.Id);
            if (book == null) return;
            db.Books.Remove(book);
            db.SaveChanges();
            LoadBooks();
        }
    }
}
