using ProjectPAW.Entities;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPAW.Forms
{
    public partial class BooksAddEdit : Form
    {
        public Book UpdatedBook { get; private set; }

        public Book _book;
        SQLiteConnection conn = new SQLiteConnection("Data Source =E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db");
        BooksForm parent;

        public BooksAddEdit(BooksForm bf, Book book)
        {
          
            InitializeComponent();
            parent = bf;
            _book = book;
        }

        public void SaveToDataBase(params object[] data)
        {
            if (_book.bookId == 0)
            {
                conn.Open();
                using (var sqlite_cmd = new SQLiteCommand("INSERT INTO Book (Title, AuthorName) VALUES (@Title, @AuthorName); SELECT last_insert_rowid();", conn))
                {
                    sqlite_cmd.Parameters.AddWithValue("@Title", data[0]);
                    sqlite_cmd.Parameters.AddWithValue("@AuthorName", data[1]);

                    sqlite_cmd.ExecuteNonQuery();

                    sqlite_cmd.CommandText = "SELECT last_insert_rowid()";
                    int newBookId = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                    _book.bookId = newBookId;
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                using (var sqlite_cmd = new SQLiteCommand("UPDATE Book SET Title = @Title, AuthorName = @AuthorName WHERE bookId = @bookId", conn))
                {
                    sqlite_cmd.Parameters.AddWithValue("@bookId", _book.bookId);
                    sqlite_cmd.Parameters.AddWithValue("@Title", data[0]);
                    sqlite_cmd.Parameters.AddWithValue("@AuthorName", data[1]);
                    sqlite_cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }


        private void BooksAddEdit_Load(object sender, EventArgs e)
        {
           
           
            if (_book == null) return;
            else
            {
               
                txtTitle.Text = _book.Title;
                txtAuthor.Text = _book.AuthorName;
            }
            parent.DisplayBooks();
        }

       

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please complete all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _book.Title = txtTitle.Text;
            _book.AuthorName = txtAuthor.Text;

            SaveToDataBase(_book.Title, _book.AuthorName);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtTitle_Validated(object sender, EventArgs e) { 
        
            errorProvider1.SetError(txtTitle, string.Empty);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
           
            if (txtTitle.Text.Length < 3)
            {
                errorProvider1.SetError(txtTitle, "Title must be at least 3 characters long");
                e.Cancel = true;
            }
        }

        private void txtAuthor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAuthor, string.Empty);
        }

        private void txtAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (txtAuthor.Text.Length < 5)
            {
                errorProvider1.SetError(txtAuthor, "Author name must be at least 5 characters long");
                e.Cancel = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void bookIdNumeric_Validated(object sender, EventArgs e)
        {
            //   errorProvider1.SetError(bookIdNumeric, string.Empty);
        }

        private void bookIdNumeric_Validating(object sender, CancelEventArgs e)
        {

            //if (bookIdNumeric.Value <= 0)
            //{
            //    errorProvider1.SetError(bookIdNumeric, "Book ID must be a positive number");
            //    e.Cancel = true;
            //}
        }
    }
}
