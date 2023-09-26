namespace ProjectPAW.Forms
{
    partial class LendingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendingForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sERIALIZEToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dESERIALIZEToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERIALIZEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESERIALIZEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sAVEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(441, 185);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Reader";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lending ID";
            this.columnHeader6.Width = 83;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(540, 96);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 48);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(540, 162);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(125, 48);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(540, 233);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(125, 48);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click add to lend a book, or click the Title if you wish to edit/remove it";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem2,
            this.deserializeToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem2
            // 
            this.serializeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sERIALIZEToolStripMenuItem3});
            this.serializeToolStripMenuItem2.Name = "serializeToolStripMenuItem2";
            this.serializeToolStripMenuItem2.Size = new System.Drawing.Size(79, 24);
            this.serializeToolStripMenuItem2.Text = "Serialize";
            // 
            // sERIALIZEToolStripMenuItem3
            // 
            this.sERIALIZEToolStripMenuItem3.Name = "sERIALIZEToolStripMenuItem3";
            this.sERIALIZEToolStripMenuItem3.Size = new System.Drawing.Size(159, 26);
            this.sERIALIZEToolStripMenuItem3.Text = "SERIALIZE";
            this.sERIALIZEToolStripMenuItem3.Click += new System.EventHandler(this.sERIALIZEToolStripMenuItem3_Click);
            // 
            // deserializeToolStripMenuItem2
            // 
            this.deserializeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESERIALIZEToolStripMenuItem3});
            this.deserializeToolStripMenuItem2.Name = "deserializeToolStripMenuItem2";
            this.deserializeToolStripMenuItem2.Size = new System.Drawing.Size(96, 24);
            this.deserializeToolStripMenuItem2.Text = "Deserialize";
            // 
            // dESERIALIZEToolStripMenuItem3
            // 
            this.dESERIALIZEToolStripMenuItem3.Name = "dESERIALIZEToolStripMenuItem3";
            this.dESERIALIZEToolStripMenuItem3.Size = new System.Drawing.Size(178, 26);
            this.dESERIALIZEToolStripMenuItem3.Text = "DESERIALIZE";
            this.dESERIALIZEToolStripMenuItem3.Click += new System.EventHandler(this.dESERIALIZEToolStripMenuItem3_Click);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sERIALIZEToolStripMenuItem1});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.serializeToolStripMenuItem.Text = "Serialize ";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // sERIALIZEToolStripMenuItem1
            // 
            this.sERIALIZEToolStripMenuItem1.Name = "sERIALIZEToolStripMenuItem1";
            this.sERIALIZEToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.sERIALIZEToolStripMenuItem1.Text = "SERIALIZE";
            this.sERIALIZEToolStripMenuItem1.Click += new System.EventHandler(this.sERIALIZEToolStripMenuItem1_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESERIALIZEToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // dESERIALIZEToolStripMenuItem1
            // 
            this.dESERIALIZEToolStripMenuItem1.Name = "dESERIALIZEToolStripMenuItem1";
            this.dESERIALIZEToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.dESERIALIZEToolStripMenuItem1.Text = "DESERIALIZE";
            this.dESERIALIZEToolStripMenuItem1.Click += new System.EventHandler(this.dESERIALIZEToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel2.Text = "Save as TXT";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVEToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // sAVEToolStripMenuItem1
            // 
            this.sAVEToolStripMenuItem1.Name = "sAVEToolStripMenuItem1";
            this.sAVEToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.sAVEToolStripMenuItem1.Text = "SAVE";
            this.sAVEToolStripMenuItem1.Click += new System.EventHandler(this.sAVEToolStripMenuItem1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel1.Text = "Save as TXT";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // LendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 337);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LendingForm";
            this.Text = "LendingForm";
            this.Load += new System.EventHandler(this.LendingForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERIALIZEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dESERIALIZEToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sERIALIZEToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dESERIALIZEToolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem1;
    }
}