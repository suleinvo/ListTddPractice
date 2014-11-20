using ListTddPractice.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListTddPractice.UI.Preseners;

namespace ListTddPractice.UI.Presenters
{
    public class MainPresenter : IPresenter
    {
        protected IView View { get; private set; }

        public MainPresenter(IView view)
        {
            View = view;
        }

        public void Run()
        {
            View.Show();
        }
    }
}
