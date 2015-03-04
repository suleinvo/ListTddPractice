using System.Collections;
using System.IO;
using ListTddPractice.UI.Preseners;
using NUnit.Framework;
using System;
using ListTddPractice.UI.Views;
using ListTddPractice.UI.Models;
using NSubstitute;
using ListTddPractice.UI.Other;

namespace ListTddPractice.Tests
{
    [TestFixture]
    public class RenderMainFormTests
    {
        private MainPresenter _mainPresenter;
        private IMainView _view;
        private IElemRepository _elemRepository;
        private IFileService _fileService;

        [TestFixtureSetUp]
        public void InitTest()
        {
            _view = Substitute.For<IMainView>();
            _fileService = Substitute.For<IFileService>();
            _elemRepository = Substitute.For<IElemRepository>();
            _mainPresenter = new MainPresenter(_view, _elemRepository, _fileService);
        }

        [Test]
        public void Run_StartAndShowView_Succesfull()
        {
            _mainPresenter.Run();
            _view.Received().Show();
        }

        [TestCase("abcd", Mode.Alpha)]
        [TestCase("123", Mode.Numeric)]
        public void Imitate_WriteAndAddElemIntoRepository_Succesfull(string elem, Mode mode)
        {
            _mainPresenter.SetModeForTest(mode);
            _view.AddWithButtonClick += Raise.Event<Action<string>>(elem);
            _elemRepository.Received().Add(Arg.Any<string>());
            //_view.CurrentList.Received().Add(Arg.Any<string>());
        }

        [Test]
        public void Imitate_DeleteElemFromRepository_Succesfull()
        {
            const string expectedValue = "exp";
            _view.DeleteButtonClick += Raise.Event<Action<string>>(expectedValue);
            _elemRepository.Received().Delete(expectedValue);       
        }

        [Test]
        public void Imitate_ClearAfterChangeMode_Succesfull()
        {
            _view.ModeChanged += Raise.Event<Action<Mode>>(Mode.Alpha);
            Assert.AreEqual(_view.CurrentList.Count, 0);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Raise_DeleteElemButtonFromRepository_ThrowError(string notSelected)
        {
            _view.DeleteButtonClick += Raise.Event<Action<string>>(notSelected);

            _view.Received().ShowError(Arg.Is<string>(t => t.Contains("Element not selected")));  
        }

        [Test]
        public void OpenFileAndRead()
        {
            Mode mode;
            var stream = Substitute.For<Stream>();
            _view.OpenFile += Raise.Event<Action<Stream>>(stream);

            _fileService.Received().ReadFile(Arg.Any<Stream>(), out mode);
        }

        [Test]
        public void SaveFile()
        {
            var stream = Substitute.For<Stream>();
            _view.SaveFile += Raise.Event<Action<Stream>>(stream);
            _fileService.Received().WriteFile(Arg.Any<IList>(), Arg.Any<Stream>());
        }
    }
}
