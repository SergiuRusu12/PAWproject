using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPAW.Entities;

namespace ProjectPAW.Forms
{
    public partial class LendingForm : Form
    {
        

        AllLendings _allLendings;
  
        private int maxLendingId = 0;
        private int nextLendingId;
     
        public LendingForm()
        {
            InitializeComponent();
            InitLendings();
          
        }

        public void InitLendings() { _allLendings = new AllLendings("All our lendings"); }

        public void DisplayLendings()
        {
            listView1.Items.Clear();
            foreach (var lending in _allLendings.AllLending)
            {
                var listViewItem = new ListViewItem(lending.bookTitle);
                listViewItem.SubItems.Add(lending.readerName);
                listViewItem.SubItems.Add(lending.lendingId.ToString());
                listViewItem.SubItems.Add(lending.bookId.ToString());
                listViewItem.SubItems.Add(lending.readerId.ToString());
                listViewItem.Tag = lending;
                listView1.Items.Add(listViewItem);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var lending = new Lending();
            lending.lendingId = nextLendingId;

            LendingAddEdit addEdit = new LendingAddEdit(lending, nextLendingId);
            if (addEdit.ShowDialog() == DialogResult.OK)
            {
                _allLendings.AllLending.Add(lending);
                DisplayLendings();

                nextLendingId++;
            }
        }



        private void editBtn_Click(object sender, EventArgs e)
        {

            var lending = listView1.SelectedItems[0].Tag as Lending;
            LendingAddEdit addEdit = new LendingAddEdit(lending);
            if (addEdit.ShowDialog() == DialogResult.OK)
            {
                DisplayLendings();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            var lending = listView1.SelectedItems[0].Tag as Lending;
            _allLendings.AllLending.Remove(lending);
            DisplayLendings();

        }

      

        private void sERIALIZEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("lendings.bin", FileMode.Create, FileAccess.Write))
            {
                binaryFormatter.Serialize(fileStream, _allLendings);
            }
        }

        private void dESERIALIZEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("lendings.bin", FileMode.Open, FileAccess.Read))
            {
                _allLendings = (AllLendings)binaryFormatter.Deserialize(fileStream);
            }

            maxLendingId = _allLendings.AllLending.Max(lending => lending.lendingId);
            nextLendingId = maxLendingId + 1;

            DisplayLendings();
        }




        private void sAVEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        foreach (Lending lending in _allLendings.AllLending)
                        {
                            sw.WriteLine(lending.ToString());
                        }
                        MessageBox.Show("Exported successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sERIALIZEToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void dESERIALIZEToolStripMenuItem1_Click(object sender, EventArgs e)
        {



        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LendingForm_Load(object sender, EventArgs e)
        {

        }
    }
}