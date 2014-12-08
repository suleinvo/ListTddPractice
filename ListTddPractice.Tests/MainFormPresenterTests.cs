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
        [TestCase(Mode.Mixed)]
        [TestCase(Mode.Numeric)]//rewrite with false
        public void Raise_WriteAndAddElemWithButtonWithMods_Succesfull(Mode mode)
        {
            var someElement = "aabbc";
            _mainPresenter.ChangeMode(mode);
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

        [TestCase(Sorting.Asc, Filter.All)]
        [TestCase(Sorting.Desc,Filter.A_z)]
        public void Options_FilterAndAscendingGet_Succesfull(string sort, string filter)
        {
            _view.UseFilter += Raise.Event<Action<string, string>>(sort,filter);
            _elemRepository.Received().Get(filter, sort);
        }

        [Test]
        public void OpenFileAndRead()
        {
            var stream = Substitute.For<Stream>();
            _view.OpenFile += Raise.Event<Action<Stream>>(stream);
            _fileService.Received().ReadFile(Arg.Any<Stream>());
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
