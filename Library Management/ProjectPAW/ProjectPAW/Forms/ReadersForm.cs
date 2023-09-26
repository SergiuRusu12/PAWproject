using ProjectPAW.Entities;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectPAW.Forms
{
    public partial class ReadersForm : Form
    {
        AllReaders _allReaders;
        public ReadersForm()
        {
            InitializeComponent();
            InitReaders();
            DisplayReaders();
        }
        public void InitReaders()
        {
            _allReaders = new AllReaders("All our readers");
            InitAllReaders();
        }
        public void InitAllReaders()
        {
            using (var sqlite_con = new SQLiteConnection("Data Source =E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db"))
            {
                sqlite_con.Open();
                using (var sqlite_cmd = new SQLiteCommand("SELECT * FROM Reader", sqlite_con))
                {
                    var reader = sqlite_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        _allReaders.Readers.Add(new Reader(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }

                }

            }
        }
        public void DisplayReaders()
        {
            listView1.Items.Clear();
            foreach (var reader in _allReaders.Readers)
            {
                var listViewItem = new ListViewItem(reader.Name);
                listViewItem.SubItems.Add(reader.Email);
                listViewItem.SubItems.Add(reader.readerId.ToString());
                listViewItem.Tag = reader;
                listView1.Items.Add(listViewItem);
            }
            listView1.FullRowSelect = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var reader = new Reader();
            ReadersAddEdit addEdit = new ReadersAddEdit(this, reader);
            if (addEdit.ShowDialog() == DialogResult.OK)
            {
                _allReaders.Readers.Add(reader);
                DisplayReaders();
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            var reader = listView1.SelectedItems[0].Tag as Reader;
            ReadersAddEdit addEdit = new ReadersAddEdit(this, reader);
            if (addEdit.ShowDialog() == DialogResult.OK)
                using (var con = new SQLiteConnection("Data Source =E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db"))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand("UPDATE Reader SET Name = @name, Email = @email where readerId = @readerId", con))
                    {
                        cmd.Parameters.AddWithValue("@readerId", reader.readerId);
                        cmd.Parameters.AddWithValue("@name", reader.Name);
                        cmd.Parameters.AddWithValue("@email", reader.Email);
                        cmd.ExecuteNonQuery();

                    }
                    con.Close();
                }
            DisplayReaders();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            var reader = listView1.SelectedItems[0].Tag as Reader;
            using (var con = new SQLiteConnection("Data Source =E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Reader WHERE readerId = @readerId", con))
                {
                    cmd.Parameters.AddWithValue("@readerId", reader.readerId);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            _allReaders.Readers.Remove(reader);
            DisplayReaders();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(listView1.Width, listView1.Height);
            listView1.DrawToBitmap(bitmap, new Rectangle(0, 0, listView1.Width, listView1.Height));
            e.Graphics.DrawImage(bitmap, 120, 20);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
