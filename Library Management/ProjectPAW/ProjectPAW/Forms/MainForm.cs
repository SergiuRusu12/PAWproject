using ProjectPAW.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ControlExtension.Draggable(lendingBtn, true);
            ControlExtension.Draggable(readersBtn, true);
            ControlExtension.Draggable(viewBooks, true);
        }

        

        private void viewBooks_Click(object sender, EventArgs e)
        {
            BooksForm form = new BooksForm();
            form.ShowDialog();
        }

        private void readersBtn_Click(object sender, EventArgs e)
        {
            ReadersForm form = new ReadersForm();
            form.ShowDialog();
        }

        private void lendingBtn_Click(object sender, EventArgs e)
        {
            LendingForm form = new LendingForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradeForm grade = new GradeForm();
            grade.ShowDialog();
        }
    }
}