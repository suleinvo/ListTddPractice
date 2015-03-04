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

namespace ListTddPractice.UI
{
    public partial class FilterList : Form
    {
        public FilterList(IList list)
        { 
            InitializeComponent();
            listBox1.DataSource = list;
        }
    }
}
