using ListTddPractice.UI.Other;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTddPractice.UI.Views
{
    public interface IMainView : IView
    {
        string CurrentElement { get; set; }
        Mode Mode { get; set; }

        IList CurrentList { get; set; }
        event Action<Mode> AddWithButtonClick;
        event Action<string> DeleteButtonClick;
        event Action<string, string> UseFilter;
        event Action<string> OpenFile;
        event Action<string> SaveFile;
    }
}
