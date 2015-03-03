using System;
using System.Data;
using System.IO;
using System.Text;
using ListTddPractice.UI.Other;
using NSubstitute.Core;
using NUnit.Framework;

namespace ListTddPractice.Tests
{
    [TestFixture]
    internal class FileServiceTests
    {
        private FileService _service;
        private MemoryStream _stream;

        [Test]
        public void WriteFile_WithMemoryMock_Succesfully()
        {
            _service = new FileService();
            string[] testValues = {"abc", "rams", "111"};
            _stream = new MemoryStream(); //mockFileStream 
            _service.WriteFile(testValues, _stream);
            string[] file = Encoding.ASCII.GetString(_stream.GetBuffer())
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array.Resize(ref file, file.Length - 1);
            CollectionAssert.AreEqual(file, testValues);
        }

        [Test]
        public void ReadFile_WithMemoryMock_Succesfully()
        {
            Mode mode;
            _service = new FileService();
            string[] testValues = { "abc", "rams", "111" };
            string file = testValues.Join(Environment.NewLine);
            _stream = new MemoryStream(Encoding.ASCII.GetBytes(file)); //mockFileStream 
            var result = _service.ReadFile(_stream, out mode);
            CollectionAssert.AreEqual(testValues, result);
        }
}
}
