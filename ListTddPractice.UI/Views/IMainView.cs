using System.IO;
using ListTddPractice.UI.Other;
using System;
using System.Collections;

namespace ListTddPractice.UI.Views
{
    public interface IMainView : IView
    {
        string CurrentElement { get; set; }
        Mode Mode { get; set; }
        IList CurrentList { get; set;}

        event Action<Mode> AddWithButtonClick;
        event Action<string> DeleteButtonClick;
        event Action<string, string> UseFilter;
        event Action<Stream> OpenFile;
        event Action<Stream> SaveFile;
    }
}
