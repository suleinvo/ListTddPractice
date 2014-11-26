using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTddPractice.UI.Models
{
    public interface IElemRepository
    {
        void Add(string elem);
        void Delete(string elem);
        string[] Get(string filter = null, string sorted = null);
    }
}
