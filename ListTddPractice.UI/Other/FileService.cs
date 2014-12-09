using System;
using System.Collections;
using System.IO;
using System.Text;

namespace ListTddPractice.UI.Other
{
    public class FileService: IFileService
    {
        public IList ReadFile(Stream stream)
        {
            using (var file = new StreamReader(stream))
            {
                return file.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

        }

        public void WriteFile(IList list, Stream stream)
        {
            using (var file = new StreamWriter(stream))
            {
                foreach (var elem in list)
                {
                    file.WriteLine(elem);
                }
            }
        }
    }
}
