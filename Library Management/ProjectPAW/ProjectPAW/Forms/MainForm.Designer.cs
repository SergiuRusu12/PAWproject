namespace ProjectPAW
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewBooks = new System.Windows.Forms.Button();
            this.readersBtn = new System.Windows.Forms.Button();
            this.lendingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewBooks
            // 
            this.viewBooks.Location = new System.Drawing.Point(89, 194);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(163, 43);
            this.viewBooks.TabIndex = 1;
            this.viewBooks.Text = "Books";
            this.viewBooks.UseVisualStyleBackColor = true;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // readersBtn
            // 
            this.readersBtn.Location = new System.Drawing.Point(326, 194);
            this.readersBtn.Name = "readersBtn";
            this.readersBtn.Size = new System.Drawing.Size(163, 43);
            this.readersBtn.TabIndex = 2;
            this.readersBtn.Text = "Readers";
            this.readersBtn.UseVisualStyleBackColor = true;
            this.readersBtn.Click += new System.EventHandler(this.readersBtn_Click);
            // 
            // lendingBtn
            // 
            this.lendingBtn.Location = new System.Drawing.Point(552, 194);
            this.lendingBtn.Name = "lendingBtn";
            this.lendingBtn.Size = new System.Drawing.Size(163, 43);
            this.lendingBtn.TabIndex = 3;
            this.lendingBtn.Text = "Lendings";
            this.lendingBtn.UseVisualStyleBackColor = true;
            this.lendingBtn.Click += new System.EventHandler(this.lendingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to our libabry, click a button to go to one of the sections";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Give us a grade!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lendingBtn);
            this.Controls.Add(this.readersBtn);
            this.Controls.Add(this.viewBooks);
            this.Name = "MainForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button viewBooks;
        private System.Windows.Forms.Button readersBtn;
        private System.Windows.Forms.Button lendingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

