using System.Collections;
using System.IO;

namespace ListTddPractice.UI.Other
{
    public interface IFileService
    {
        IList ReadFile(Stream stream, out Mode mode);
        void WriteFile(IList list, Stream stream);
    }
}
