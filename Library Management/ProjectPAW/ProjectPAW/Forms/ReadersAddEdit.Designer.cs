namespace ProjectPAW.Forms
{
    partial class ReadersAddEdit
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // addBtn
            // 
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Location = new System.Drawing.Point(43, 139);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(187, 139);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 8;
            this.cancBtn.Text = "Cancel";
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ReadersAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 203);
            this.Controls.Add(this.cancBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Name = "ReadersAddEdit";
            this.Text = "ReadersAddEdit";
            this.Load += new System.EventHandler(this.ReadersAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}