using ListTddPractice.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListTddPractice.UI.Preseners;
using ListTddPractice.BL;

namespace ListTddPractice.UI.Presenters
{
    public class MainPresenter : IPresenter
    {
        private IView _view;
        private IListService _listService;

        public MainPresenter(IMainView view, IListService service)
        {
            _view = view;
            _listService = service;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
