using System.Collections;
using System.IO;
using ListTddPractice.UI.Preseners;
using NUnit.Framework;
using System;
using ListTddPractice.UI.Views;
using ListTddPractice.UI.Models;
using NSubstitute;
using ListTddPractice.UI.Constants;
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
        
        [TestCase(Mode.Alpha)]
        public void Raise_WriteAndAddElemWithButtonWithMods_Succesfull(Mode mode)
        {
            const string someElement = "aabbc";
            _view.AddWithButtonClick += Raise.Event<Action<string>>(someElement);
            _elemRepository.Received().Add(Arg.Any<string>());
        }

        [Test]
        public void Raise_DeleteElemButton_Succesfull()
        {
            const string expectedValue = "exp";
            _view.DeleteButtonClick += Raise.Event<Action<string>>(expectedValue);
            _elemRepository.Received().Delete(expectedValue);       
        }

        [TestCase(null)]
        [TestCase("")]
        public void Raise_DeleteElemButtonNotSelected_ThrowError(string notSelected)
        {
            _view.DeleteButtonClick += Raise.Event<Action<string>>(notSelected);

            _view.Received().ShowError(Arg.Is<string>(t => t.Contains("Element not selected")));  
        }

        [TestCase(Sorting.Asc)]
        [TestCase(Sorting.Desc)]
        public void Options_FilterAndAscendingGet_Succesfull(string sort)
        {
            _view.SortChanged += Raise.Event<Action<string>>(sort);
            _elemRepository.Received().Get(sort);
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
