namespace ListTddPractice.UI
{
    partial class MainView
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
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.elemRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterElemBox = new System.Windows.Forms.TextBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.alphaRadioButton = new System.Windows.Forms.RadioButton();
            this.numericRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sortedDescRadioButton = new System.Windows.Forms.RadioButton();
            this.sortedAscRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elemRepositoryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainListBox
            // 
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 16;
            this.mainListBox.Location = new System.Drawing.Point(316, 81);
            this.mainListBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(293, 164);
            this.mainListBox.TabIndex = 0;
            // 
            // elemRepositoryBindingSource
            // 
            this.elemRepositoryBindingSource.DataSource = typeof(ListTddPractice.UI.Models.ElemRepository);
            // 
            // enterElemBox
            // 
            this.enterElemBox.Location = new System.Drawing.Point(316, 36);
            this.enterElemBox.Margin = new System.Windows.Forms.Padding(4);
            this.enterElemBox.Name = "enterElemBox";
            this.enterElemBox.Size = new System.Drawing.Size(293, 22);
            this.enterElemBox.TabIndex = 1;
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(640, 36);
            this.addNewButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(119, 43);
            this.addNewButton.TabIndex = 2;
            this.addNewButton.Text = "Add new";
            this.addNewButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(640, 91);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 43);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // alphaRadioButton
            // 
            this.alphaRadioButton.AutoSize = true;
            this.alphaRadioButton.Location = new System.Drawing.Point(16, 4);
            this.alphaRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.alphaRadioButton.Name = "alphaRadioButton";
            this.alphaRadioButton.Size = new System.Drawing.Size(65, 21);
            this.alphaRadioButton.TabIndex = 4;
            this.alphaRadioButton.TabStop = true;
            this.alphaRadioButton.Text = "Alpha";
            this.alphaRadioButton.UseVisualStyleBackColor = true;
            // 
            // numericRadioButton
            // 
            this.numericRadioButton.AutoSize = true;
            this.numericRadioButton.Location = new System.Drawing.Point(16, 32);
            this.numericRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.numericRadioButton.Name = "numericRadioButton";
            this.numericRadioButton.Size = new System.Drawing.Size(81, 21);
            this.numericRadioButton.TabIndex = 5;
            this.numericRadioButton.TabStop = true;
            this.numericRadioButton.Text = "Numeric";
            this.numericRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alphaRadioButton);
            this.panel1.Controls.Add(this.numericRadioButton);
            this.panel1.Location = new System.Drawing.Point(8, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 62);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(268, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(16, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(268, 110);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sortedDescRadioButton);
            this.panel2.Controls.Add(this.sortedAscRadioButton);
            this.panel2.Location = new System.Drawing.Point(8, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 64);
            this.panel2.TabIndex = 12;
            // 
            // sortedDescRadioButton
            // 
            this.sortedDescRadioButton.AutoSize = true;
            this.sortedDescRadioButton.Location = new System.Drawing.Point(16, 33);
            this.sortedDescRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortedDescRadioButton.Name = "sortedDescRadioButton";
            this.sortedDescRadioButton.Size = new System.Drawing.Size(104, 21);
            this.sortedDescRadioButton.TabIndex = 1;
            this.sortedDescRadioButton.TabStop = true;
            this.sortedDescRadioButton.Text = "Descending";
            this.sortedDescRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortedAscRadioButton
            // 
            this.sortedAscRadioButton.AutoSize = true;
            this.sortedAscRadioButton.Location = new System.Drawing.Point(16, 4);
            this.sortedAscRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortedAscRadioButton.Name = "sortedAscRadioButton";
            this.sortedAscRadioButton.Size = new System.Drawing.Size(95, 21);
            this.sortedAscRadioButton.TabIndex = 0;
            this.sortedAscRadioButton.TabStop = true;
            this.sortedAscRadioButton.Text = "Ascending";
            this.sortedAscRadioButton.UseVisualStyleBackColor = true;
            this.sortedAscRadioButton.CheckedChanged += new System.EventHandler(this.sortedAscRadioButton_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(773, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(640, 202);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 43);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 265);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.enterElemBox);
            this.Controls.Add(this.mainListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "List";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elemRepositoryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.TextBox enterElemBox;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton alphaRadioButton;
        private System.Windows.Forms.RadioButton numericRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton sortedDescRadioButton;
        private System.Windows.Forms.RadioButton sortedAscRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource elemRepositoryBindingSource;
    }
}

