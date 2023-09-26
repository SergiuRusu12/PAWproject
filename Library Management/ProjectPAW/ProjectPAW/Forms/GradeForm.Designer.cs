namespace ProjectPAW.Forms
{
    partial class GradeForm
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
            this.gradeControl1 = new GradeControl.control.GradeControl();
            this.SuspendLayout();
            // 
            // gradeControl1
            // 
            this.gradeControl1.Location = new System.Drawing.Point(12, 12);
            this.gradeControl1.Name = "gradeControl1";
            this.gradeControl1.Size = new System.Drawing.Size(343, 236);
            this.gradeControl1.TabIndex = 0;
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 272);
            this.Controls.Add(this.gradeControl1);
            this.Name = "GradeForm";
            this.Text = "Grade us!";
            this.ResumeLayout(false);

        }

        #endregion

        private GradeControl.control.GradeControl gradeControl1;
    }
}