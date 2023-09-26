namespace ProjectPAW.Forms
{
    partial class BooksAddEdit
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
            this.components = new System.ComponentModel.Container();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(214, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(120, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            this.txtTitle.Validated += new System.EventHandler(this.txtTitle_Validated);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(214, 122);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(120, 22);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtAuthor_Validating);
            this.txtAuthor.Validated += new System.EventHandler(this.txtAuthor_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(97, 183);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 6;
            this.cancBtn.Text = "Cancel";
            this.cancBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Location = new System.Drawing.Point(259, 183);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BooksAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 258);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "BooksAddEdit";
            this.Text = "BooksAddEdit";
            this.Load += new System.EventHandler(this.BooksAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}