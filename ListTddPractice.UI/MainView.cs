using ListTddPractice.UI.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListTddPractice.UI.Constants;
using ListTddPractice.UI.Other;
using System.IO;

namespace ListTddPractice.UI
{
    public partial class MainView : Form, IMainView
    {
        public event Action<Mode> AddWithButtonClick;
        public event Action<string> DeleteButtonClick;
        public event Action<string> OpenFile;
        public event Action<string> SaveFile;
        public event Action<string, string> UseFilter;

        public string CurrentElement { get; set; }
        public IList CurrentList { get; set; }

        public Mode Mode { get; set; }

        public MainView()
        {
            InitializeComponent();
            CurrentList = this.mainListBox.Items;
            addNewButton.Click += (sender, e) => AddWithButtonClick(Mode);
            deleteButton.Click += (sender, e) => DeleteButtonClick(mainListBox.SelectedItem.ToString());
            sortedAscRadioButton.Click += (sender, e) => UseFilter(filterComboBox.SelectedText, Sorting.Asc);
            sortedDescRadioButton.Click += (sender, e) => UseFilter(filterComboBox.SelectedText, Sorting.Desc);
            openFileDialog1.FileOk += (sender, e) => OpenFile(openFileDialog1.FileName);
            saveFileDialog1.FileOk += (sender, e) => SaveFile(saveFileDialog1.FileName);
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public new void Close()
        {
            Application.Exit();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
