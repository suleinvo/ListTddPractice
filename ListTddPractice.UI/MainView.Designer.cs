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
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.enterElemBox = new System.Windows.Forms.TextBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.alphaRadioButton = new System.Windows.Forms.RadioButton();
            this.numericRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sortedDescRadioButton = new System.Windows.Forms.RadioButton();
            this.sortedAscRadioButton = new System.Windows.Forms.RadioButton();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.mainListBox.Location = new System.Drawing.Point(237, 66);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(221, 212);
            this.mainListBox.TabIndex = 0;
            // 
            // enterElemBox
            // 
            this.enterElemBox.Location = new System.Drawing.Point(237, 29);
            this.enterElemBox.Name = "enterElemBox";
            this.enterElemBox.Size = new System.Drawing.Size(221, 20);
            this.enterElemBox.TabIndex = 1;
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(480, 29);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(89, 35);
            this.addNewButton.TabIndex = 2;
            this.addNewButton.Text = "Add new";
            this.addNewButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(480, 74);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 35);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // alphaRadioButton
            // 
            this.alphaRadioButton.AutoSize = true;
            this.alphaRadioButton.Location = new System.Drawing.Point(12, 3);
            this.alphaRadioButton.Name = "alphaRadioButton";
            this.alphaRadioButton.Size = new System.Drawing.Size(52, 17);
            this.alphaRadioButton.TabIndex = 4;
            this.alphaRadioButton.TabStop = true;
            this.alphaRadioButton.Text = "Alpha";
            this.alphaRadioButton.UseVisualStyleBackColor = true;
            // 
            // numericRadioButton
            // 
            this.numericRadioButton.AutoSize = true;
            this.numericRadioButton.Location = new System.Drawing.Point(12, 26);
            this.numericRadioButton.Name = "numericRadioButton";
            this.numericRadioButton.Size = new System.Drawing.Size(64, 17);
            this.numericRadioButton.TabIndex = 5;
            this.numericRadioButton.TabStop = true;
            this.numericRadioButton.Text = "Numeric";
            this.numericRadioButton.UseVisualStyleBackColor = true;
            // 
            // mixedRadioButton
            // 
            this.mixedRadioButton.AutoSize = true;
            this.mixedRadioButton.Location = new System.Drawing.Point(12, 49);
            this.mixedRadioButton.Name = "mixedRadioButton";
            this.mixedRadioButton.Size = new System.Drawing.Size(53, 17);
            this.mixedRadioButton.TabIndex = 6;
            this.mixedRadioButton.TabStop = true;
            this.mixedRadioButton.Text = "Mixed";
            this.mixedRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alphaRadioButton);
            this.panel1.Controls.Add(this.mixedRadioButton);
            this.panel1.Controls.Add(this.numericRadioButton);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 76);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.filterComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sortedDescRadioButton);
            this.panel2.Controls.Add(this.sortedAscRadioButton);
            this.panel2.Location = new System.Drawing.Point(6, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 87);
            this.panel2.TabIndex = 12;
            // 
            // sortedDescRadioButton
            // 
            this.sortedDescRadioButton.AutoSize = true;
            this.sortedDescRadioButton.Location = new System.Drawing.Point(12, 44);
            this.sortedDescRadioButton.Name = "sortedDescRadioButton";
            this.sortedDescRadioButton.Size = new System.Drawing.Size(82, 17);
            this.sortedDescRadioButton.TabIndex = 1;
            this.sortedDescRadioButton.TabStop = true;
            this.sortedDescRadioButton.Text = "Descending";
            this.sortedDescRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortedAscRadioButton
            // 
            this.sortedAscRadioButton.AutoSize = true;
            this.sortedAscRadioButton.Location = new System.Drawing.Point(12, 21);
            this.sortedAscRadioButton.Name = "sortedAscRadioButton";
            this.sortedAscRadioButton.Size = new System.Drawing.Size(75, 17);
            this.sortedAscRadioButton.TabIndex = 0;
            this.sortedAscRadioButton.TabStop = true;
            this.sortedAscRadioButton.Text = "Ascending";
            this.sortedAscRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "All",
            "None",
            "A-Z",
            "0-10000"});
            this.filterComboBox.Location = new System.Drawing.Point(56, 19);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(129, 21);
            this.filterComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.enterElemBox);
            this.Controls.Add(this.mainListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.RadioButton mixedRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton sortedDescRadioButton;
        private System.Windows.Forms.RadioButton sortedAscRadioButton;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

