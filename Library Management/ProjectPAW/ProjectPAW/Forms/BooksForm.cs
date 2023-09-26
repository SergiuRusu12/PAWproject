using ProjectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectPAW.Forms
{
    public partial class BooksForm : Form
    {
        Library _library;
        public BooksForm()
        {
            InitializeComponent();
            InitLibrary();
            DisplayBooks();
        }

        public void InitLibrary()
        {
            _library = new Library("My library");
            InitAllBooks();
        }

        public void InitAllBooks()
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source = E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db"))
            {
                sqlite_conn.Open();
                using (var sqlite_cmd = new SQLiteCommand("SELECT * FROM Book", sqlite_conn))
                {
                   
                   var reader = sqlite_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        _library.Books.Add(new Book(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
            }
        }

        public void DisplayBooks()
        {
           listView1.Items.Clear();
            
            foreach (var book in _library.Books)
            {
                var listview = new ListViewItem(book.Title);
                listview.SubItems.Add(book.AuthorName);
                listview.SubItems.Add(book.bookId.ToString());
                listview.Tag = book;
                listView1.Items.Add(listview);


            }
            listView1.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = new Book(); 
            BooksAddEdit addEdit = new BooksAddEdit(this, book);
            if (addEdit.ShowDialog() == DialogResult.OK)
            {
                book = addEdit._book; 
                _library.Books.Add(book); 
                DisplayBooks();
            }
        }




        private void editBtn_Click(object sender, EventArgs e)
        {
            var book = listView1.SelectedItems[0].Tag as Book;
            var editedBook = new Book(book.bookId, book.Title, book.AuthorName); 
            BooksAddEdit addEdit = new BooksAddEdit(this, editedBook);
            if (addEdit.ShowDialog() == DialogResult.OK)
            {
                
                book.Title = editedBook.Title;
                book.AuthorName = editedBook.AuthorName;
                using (var con = new SQLiteConnection("Data Source=E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db"))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand("UPDATE Book SET Title = @Title, AuthorName = @AuthorName WHERE bookId = @bookId", con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", book.bookId);
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@AuthorName", book.AuthorName);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                DisplayBooks();
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var book = listView1.SelectedItems[0].Tag as Book;
            using (var con = new SQLiteConnection("Data Source=E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Book WHERE bookId = @bookId", con))
                {
                    cmd.Parameters.AddWithValue("@bookId", book.bookId);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            _library.Books.Remove(book);
            DisplayBooks();
        }




    

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> booksPerAuthor = new Dictionary<string, int>();

            foreach (var book in _library.Books)
            {
                if (booksPerAuthor.ContainsKey(book.AuthorName))
                    booksPerAuthor[book.AuthorName]++;
                else
                    booksPerAuthor.Add(book.AuthorName, 1);
            }

            ShowBarChart(booksPerAuthor);
        }

        private void ShowBarChart(Dictionary<string, int> data)
        {
            Form chartForm = new Form
            {
                Width = 1000,
                Height = 600,
                Text = "Books per Author"
            };

            Panel chartPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            chartPanel.Paint += (sender, e) =>
            {
                int barWidth = chartPanel.Width / (data.Count * 2);
                int maxValue = GetMaxValue(data);

                int x = 0;
                foreach (var pair in data)
                {
                    string label = pair.Key;
                    int value = pair.Value;

                    int barHeight = (int)((double)value / maxValue * (chartPanel.Height - 30));

                    Rectangle rect = new Rectangle(x, chartPanel.Height - barHeight, barWidth, barHeight);
                    using (Brush brush = new SolidBrush(Color.Aquamarine))
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }

                    e.Graphics.DrawString(label, Font, Brushes.Black, x, chartPanel.Height - 20);

                    x += barWidth * 2;
                }
            };

            chartForm.Controls.Add(chartPanel);
            chartForm.ShowDialog();
        }


        private int GetMaxValue(Dictionary<string, int> data)
        {
            int maxValue = 0;
            foreach (var value in data.Values)
            {
                if (value > maxValue)
                    maxValue = value;
            }
            return maxValue;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }


    }
}
