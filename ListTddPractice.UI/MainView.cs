using System.IO;
using ListTddPractice.UI.Views;
using System;
using System.Collections;
using System.Windows.Forms;
using ListTddPractice.UI.Constants;
using ListTddPractice.UI.Other;
using System.Linq;

namespace ListTddPractice.UI
{
    public partial class MainView : Form, IMainView
    {
        public event Action<string> AddWithButtonClick;
        public event Action<string> DeleteButtonClick;
        public event Action<Stream> OpenFile;
        public event Action<Stream> SaveFile;
        public event Action<string> SortChanged;
        public event Action<Mode> ModeChanged;
        public event Action Clear;

        public string CurrentElement { get; set; }
        private Mode _mode = Mode.Alpha;

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

        public Mode Mode
        {
            get { return _mode; }
            set
            {
                if (value == Mode.Alpha)
                {
                    alphaRadioButton.Checked = true;
                    _mode = Mode.Alpha;
                }
                else
                {
                    numericRadioButton.Checked = true;
                    _mode = Mode.Numeric;
                }
            }
        }

        public MainView()
        {
            InitializeComponent();
            //Init Filter Files
            openFileDialog1.Filter = @"(*.lst)|*.lst";
            saveFileDialog1.Filter = @"(*.lst)|*.lst";
            alphaRadioButton.Checked = true;

            //Button Action Changes
            addNewButton.Click += (sender, e) => AddWithButtonClick(enterElemBox.Text);
            deleteButton.Click += (sender, e) => DeleteButtonClick(mainListBox.SelectedItem.ToString());
            clearButton.Click += (sender, e) => Clear();

            sortedAscRadioButton.Click += (sender, e) => SortChanged(Sorting.Asc);
            sortedDescRadioButton.Click += (sender, e) => SortChanged(Sorting.Desc);

            //Save Changes
            openFileDialog1.FileOk += (sender, e) => OpenFile(openFileDialog1.OpenFile());
            saveFileDialog1.FileOk += (sender, e) => SaveFile(saveFileDialog1.OpenFile());

            //Radio Button Changed
            alphaRadioButton.CheckedChanged += (sender, e) => ModeChanged(CheckedChangedHelper(sender));
            numericRadioButton.CheckedChanged += (sender, e) => ModeChanged(CheckedChangedHelper(sender));
        }

        public Mode CheckedChangedHelper(object sender)
        {
            var radioButton = sender as RadioButton;
            if (CurrentList.Count != 0)
            {
                saveFileDialog1.ShowDialog();
            }
            if (radioButton.Text == "Alpha")
            {
                return Mode.Alpha;
            }
            return Mode.Numeric;
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
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                AddWithButtonClick(enterElemBox.Text);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void sortedAscRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
