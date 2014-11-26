using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListTddPractice.UI.Presenters;
using ListTddPractice.UI.Views;
using ListTddPractice.UI.Models;
using NSubstitute;
using System.Collections;
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
            //write element
            _view.CurrentElement.Returns("Somevalue");
            //press button
            _view.AddWithButtonClick += Raise.Event<Action<Mode>>(mode);
            _elemRepository.Received().Add(Arg.Any<string>());
        }

        [Test]
        public void Raise_DeleteElemButton_Succesfull()
        {
            string expectedValue = "exp";
            _view.DeleteButtonClick += Raise.Event<Action<string>>(expectedValue);
            _elemRepository.Received().Delete(expectedValue);       
        }

        [TestCase(null)]
        [TestCase("")]
        [ExpectedException(typeof(Exception))]
        public void Raise_DeleteElemButtonNotSelected_ThrowError(string notSelected)
        {
            _view.DeleteButtonClick += Raise.Event<Action<string>>(notSelected);
            _elemRepository.Received().Delete(notSelected);  
        }

        [TestCase(Sorting.Asc, Filter.All)]
        [TestCase(Sorting.Desc,Filter.A_z)]
        public void Options_FilterAndAscendingGet_Succesfull(string sort, string filter)
        {
            _view.UseFilter += Raise.Event<Action<string, string>>(sort,filter);
            _elemRepository.Received().Get(sort, filter);
        }

        [Test]
        public void OpenFileAndRead()
        {
            string fileName = "somename.txt";
            _view.OpenFile += Raise.Event<Action<string>>(fileName);
            _fileService.Received().ReadFile(fileName);
        }

        [Test]
        public void SaveFile()
        {
            string filename = "someone.txt";
           // _view.SaveFile += 

        }
    }
}
