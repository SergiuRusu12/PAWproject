namespace ProjectPAW
{
    partial class LendingAddEdit
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
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(172, 62);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(120, 22);
            this.txtReaderName.TabIndex = 2;
            this.txtReaderName.Validating += new System.ComponentModel.CancelEventHandler(this.txtReaderName_Validating);
            this.txtReaderName.Validated += new System.EventHandler(this.txtReaderName_Validated);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(172, 119);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(120, 22);
            this.txtBookTitle.TabIndex = 3;
            this.txtBookTitle.TextChanged += new System.EventHandler(this.txtBookTitle_TextChanged);
            this.txtBookTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookTitle_Validating);
            this.txtBookTitle.Validated += new System.EventHandler(this.txtBookTitle_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reader Name";
            // 
            // addBtn
            // 
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Location = new System.Drawing.Point(346, 22);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(126, 62);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(346, 101);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(132, 59);
            this.cancBtn.TabIndex = 10;
            this.cancBtn.Text = "Cancel";
            this.cancBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LendingAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 176);
            this.Controls.Add(this.cancBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtReaderName);
            this.Name = "LendingAddEdit";
            this.Text = "AddEditForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}