using System.Collections;
using System.IO;

namespace ListTddPractice.UI.Other
{
    public interface IFileService
    {
        IList ReadFile(Stream stream);
        void WriteFile(IList list, Stream stream);
    }
}
