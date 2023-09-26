using ProjectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPAW
{
    public partial class LendingAddEdit : Form
    {


        private static int nextLendingId;

        public LendingAddEdit(Lending lending, int nextLendingId) : this()
        {
            _lending = lending;
            LendingAddEdit.nextLendingId = nextLendingId;
        }


        Lending _lending = new Lending();
        AllReaders _allReaders= new AllReaders();
        Library _allBooks = new Library();
       
        public LendingAddEdit()
        {
            InitializeComponent();
        }

        public LendingAddEdit(Lending lending) : this() 
        {
            _lending = lending;
           
        }

        public LendingAddEdit(Lending lending, AllReaders allReaders, Library library)
        {
            InitializeComponent();
            _allReaders = allReaders;
            _allBooks = library;
            
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (_lending == null) return;
            else
            {

                txtBookTitle.Text = _lending.bookTitle;
                txtReaderName.Text = _lending.readerName;
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            if (!ValidateChildren())
            {
                MessageBox.Show("Please correct the errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_lending != null)
            {
                _lending.lendingId = nextLendingId;
                _lending.readerId = rnd.Next(1, 10);
                _lending.bookId = rnd.Next(1, 10);
                _lending.bookTitle = txtBookTitle.Text;
                _lending.readerName = txtReaderName.Text;
                _lending.bookId = _allBooks.Books.Where(x => x.Title == txtBookTitle.Text).Select(x => x.bookId).FirstOrDefault();
                _lending.readerId = _allReaders.Readers.Where(x => x.Name == txtReaderName.Text).Select(x => x.readerId).FirstOrDefault();
            }
        }

       
        private void txtBookTitle_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBookTitle, string.Empty);
        }

        private void txtBookTitle_Validating(object sender, CancelEventArgs e)
        {
  
            if(txtBookTitle.Text.Length < 2)
            {
                errorProvider1.SetError(txtBookTitle, "The title should have more than 2 characters");
                e.Cancel = true;
            }
        }

        private void txtReaderName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtReaderName, string.Empty);
        }

        private void txtReaderName_Validating(object sender, CancelEventArgs e)
        {
  
            if(txtReaderName.Text.Length < 4)
            {
                errorProvider1.SetError(txtReaderName, "The name should have more than 6 characters");
                e.Cancel = true;
            }
        }

        private void lendingIdNumeric_Validated(object sender, EventArgs e)
        {

            // errorProvider1.SetError(lendingIdNumeric, string.Empty);

        }

        private void lendingIdNumeric_Validating(object sender, CancelEventArgs e)
        {

            //  if (lendingIdNumeric.Value <= 0)
            //{
            //  errorProvider1.SetError(lendingIdNumeric, "The lending id cannot be 0");
            //e.Cancel = true;
            //}


        }

        private void bookIdNumeric_Validated(object sender, EventArgs e)
        {
            //  errorProvider1.SetError(bookIdNumeric, string.Empty);
        }

        private void bookIdNumeric_Validating(object sender, CancelEventArgs e)
        {
            //if(bookIdNumeric.Value <= 0)
            //{
            //    errorProvider1.SetError(bookIdNumeric, "The book id cannot be 0");
            //    e.Cancel = true;
            //}
        }

        private void readerIdNumeric_Validated(object sender, EventArgs e)
        {
            // errorProvider1.SetError(readerIdNumeric, string.Empty);
        }

        private void readerIdNumeric_Validating(object sender, CancelEventArgs e)
        {
            // if(readerIdNumeric.Value <= 0)
            //  {
            //      errorProvider1.SetError(readerIdNumeric, "The reader id cannot be 0");
            //      e.Cancel = true;
            //  }
        }


        private void lendingIdNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
