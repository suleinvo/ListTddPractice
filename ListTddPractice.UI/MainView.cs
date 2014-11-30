using System.IO;
using ListTddPractice.UI.Views;
using System;
using System.Collections;
using System.Windows.Forms;
using ListTddPractice.UI.Constants;
using ListTddPractice.UI.Other;

namespace ListTddPractice.UI
{
    public partial class MainView : Form, IMainView
    {
        public event Action<Mode> AddWithButtonClick;
        public event Action<string> DeleteButtonClick;
        public event Action<Stream> OpenFile;
        public event Action<Stream> SaveFile;
        public event Action<string, string> UseFilter;

        public string CurrentElement { get; set; }

        public IList CurrentList
        {
            get { return mainListBox.Items; }
            set 
            { 
                mainListBox.Items.Clear();
                foreach (var elem in value)
                {
                    mainListBox.Items.Add(elem);
                }
            }
        }

        public Mode Mode { get; set; }

        public MainView()
        {
            InitializeComponent();
            addNewButton.Click += (sender, e) => AddWithButtonClick(Mode);
            deleteButton.Click += (sender, e) => DeleteButtonClick(mainListBox.SelectedItem.ToString());
            sortedAscRadioButton.Click += (sender, e) => UseFilter(filterComboBox.SelectedText, Sorting.Asc);
            sortedDescRadioButton.Click += (sender, e) => UseFilter(filterComboBox.SelectedText, Sorting.Desc);
            openFileDialog1.FileOk += (sender, e) => OpenFile(openFileDialog1.OpenFile());
            saveFileDialog1.FileOk += (sender, e) => SaveFile(saveFileDialog1.OpenFile());
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
    }
}
