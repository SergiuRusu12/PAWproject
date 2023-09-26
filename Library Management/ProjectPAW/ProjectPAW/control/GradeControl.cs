using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeControl.control
{
    public partial class GradeControl : UserControl
    {
        public GradeControl()
        {
            InitializeComponent();
        }

    

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            //values must be between 1 and 10, throw message if not error
            if (numericUpDown1.Value < 1 || numericUpDown1.Value > 10)
            {
                MessageBox.Show("Grade must be between 1 and 10");
                e.Cancel = true;
            }


        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            //set the color green if the grade is 8 or higher, yellow if its between 5 and 7, red if its lower than 5, and show a message box that says thank you at the end
            if (numericUpDown1.Value >= 8)
            {
                numericUpDown1.BackColor = Color.Green;
            }
            else if (numericUpDown1.Value >= 5 && numericUpDown1.Value < 8)
            {
                numericUpDown1.BackColor = Color.Yellow;
            }
            else if (numericUpDown1.Value < 5)
            {
                numericUpDown1.BackColor = Color.Red;
            }
            MessageBox.Show("Thank you");

        }




            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.ParentForm.Close();
        }
    }
}
