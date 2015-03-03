using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ListTddPractice.UI.Other
{
    public class FileService: IFileService
    {
        public IList ReadFile(Stream stream, out Mode mode)
        {
            using (var file = new StreamReader(stream))
            {
                mode = Mode.Alpha;
                string[] elements = file.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int i = 0;
                if (elements.Any(t => int.TryParse(t, out i)))
                {
                    mode = Mode.Numeric;
                }
                mode = Mode.Alpha;
                return elements.ToList();
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
