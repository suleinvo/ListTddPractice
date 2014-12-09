using System.IO;
using ListTddPractice.UI.Other;
using System;
using System.Collections;

namespace ListTddPractice.UI.Views
{
    public interface IMainView : IView
    {
        string CurrentElement { get; set; }
        IList CurrentList { get; set;}

        event Action<string> AddWithButtonClick;
        event Action<string> DeleteButtonClick;
        event Action<string, string> UseFilter;
        event Action<Stream> OpenFile;
        event Action<Stream> SaveFile;
        event Action<Mode> ModeChanged;
        event Action Clear;
        event Action<string> SortChanged;
    }
}
