using ProjectPAW.Entities;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjectPAW.Forms
{
    public partial class ReadersAddEdit : Form
    {
        Reader _reader;
        SQLiteConnection conn = new SQLiteConnection
            ("Data Source =E:\\Facultate\\An2Sem2\\SDD\\ProjectPAW\\PawDataBase.db");
        ReadersForm parent;


        public ReadersAddEdit(ReadersForm rf, Reader reader)
        {
            InitializeComponent();
            parent = rf;
            _reader = reader;
        }


        public void SaveToDataBase(params object[] data)
        {
            if (_reader.readerId == 0)
            {
                conn.Open();
                using (var sqlite_cmd = new SQLiteCommand("INSERT INTO Reader (Name, Email) VALUES (@Name, @Email); SELECT last_insert_rowid();", conn))
                {
                    sqlite_cmd.Parameters.AddWithValue("@Name", data[1]);
                    sqlite_cmd.Parameters.AddWithValue("@Email", data[2]);

                    int newReaderId = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                    _reader.readerId = newReaderId;
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                using (var sqlite_cmd = new SQLiteCommand("UPDATE Reader SET Name = @Name, Email = @Email WHERE readerId = @readerId", conn))
                {
                    sqlite_cmd.Parameters.AddWithValue("@readerId", data[0]);
                    sqlite_cmd.Parameters.AddWithValue("@Name", data[1]);
                    sqlite_cmd.Parameters.AddWithValue("@Email", data[2]);
                    sqlite_cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please correct the errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _reader.Name = txtName.Text;
            _reader.Email = txtEmail.Text;

            SaveToDataBase(_reader.readerId, _reader.Name, _reader.Email);

            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void ReadersAddEdit_Load(object sender, EventArgs e)
        {
            if (_reader == null) return;
            else
            {
               
                txtName.Text = _reader.Name;
                txtEmail.Text = _reader.Email;
            }
            parent.DisplayReaders();
        }

      

        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, string.Empty);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            
            if (txtName.Text.Length < 3)
            {
                errorProvider1.SetError(txtName, "Name must be at least 3 characters");
                e.Cancel = true;
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEmail, string.Empty);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (txtEmail.Text.Length < 10 || !txtEmail.Text.Contains("@gmail.com"))
            {
                errorProvider1.SetError(txtEmail, "Email must be at least 10 characters and contain @gmail.com");
                e.Cancel = true;
            }
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {

        }

        private void idNumeric_Validated(object sender, EventArgs e)
        {
            //   errorProvider1.SetError(idNumeric, string.Empty);
        }

        private void idNumeric_Validating(object sender, CancelEventArgs e)
        {
            // if (idNumeric.Value <= 0)
            //{
            //  errorProvider1.SetError(idNumeric, "Id must be positive");
            //e.Cancel = true;
            //}
        }
    }
}
