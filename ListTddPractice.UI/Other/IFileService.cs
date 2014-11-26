using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTddPractice.UI.Other
{
    public interface IFileService
    {
        IList ReadFile(string name);
        void WriteFile(IList list, string name);
    }
}
