using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListTddPractice.UI.Models;
using ListTddPractice.UI.Other;
using ListTddPractice.UI.Preseners;

namespace ListTddPractice.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new MainPresenter(new MainView(), new ElemRepository(), new FileService());
            presenter.Run();
        }
    }
}
