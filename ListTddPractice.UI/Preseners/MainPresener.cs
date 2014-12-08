using System;
using System.IO;
using ListTddPractice.UI.Models;
using ListTddPractice.UI.Other;
using ListTddPractice.UI.Views;

namespace ListTddPractice.UI.Preseners
{
    public class MainPresenter : IPresenter
    {
        private readonly IMainView _view;
        private readonly IElemRepository _elemRepository;
        private readonly IFileService _fileService;
        private Mode _mode;

        public MainPresenter(IMainView view, IElemRepository reposiory, IFileService fileService)
        {
            _elemRepository = reposiory;
            _fileService = fileService;
            _view = view;
            _view.AddWithButtonClick += (elem) => AddToRepository(elem);
            _view.DeleteButtonClick += DeleteFromRepository;
            _view.UseFilter += (sort, filter) => UseFilter(filter, sort);
            _view.OpenFile += OpenFile;
            _view.SaveFile += SaveFile;
            _view.Clear += Clear;
            _view.ModeChanged += (mode) => ChangeMode(mode);
        }

        public void Run()
        {
            _view.Show();
        }

        public void AddToRepository(string elem)
        {
            try
            {
                IsNullOrEmpty(elem);
                _elemRepository.Add(RepositoryHelper.Validate(elem, _mode));
                _view.CurrentList = _elemRepository.Get();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void DeleteFromRepository(string elem)
        {
            try
            {
                IsNullOrEmpty(elem);
                _elemRepository.Delete(elem);
                _view.CurrentList = _elemRepository.Get();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void UseFilter(string filter, string sort)
        {
            _view.CurrentList =  _elemRepository.Get(filter, sort);
        }

        public void OpenFile(Stream stream)
        {
            _view.CurrentList = _fileService.ReadFile(stream); 
        }

        public void SaveFile(Stream stream)
        {
            _fileService.WriteFile(_view.CurrentList, stream);
        }

        public void ChangeMode(Mode mode)
        {
            if (_mode != mode)
            {
                _mode = mode;
                _view.CurrentList.Clear();
                _elemRepository.Clear();
                //_fileService.WriteFile()
            }
        }

        public void Clear()
        {
            _view.CurrentList.Clear();
            _elemRepository.Clear();
        }

        private void IsNullOrEmpty(string elem)
        {
            if (string.IsNullOrEmpty(elem)) throw new Exception("Element not selected");
        }
    }
}
