using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListTddPractice.UI.Views
{
    public interface IView
    {
        void Show();
        void Close();
        void ShowError(string message);
    }
}
