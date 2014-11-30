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

        public MainPresenter(IMainView view, IElemRepository reposiory, IFileService fileService)
        {
            _view = view;
            _elemRepository = reposiory;
            _fileService = fileService;
            _view.AddWithButtonClick += arg => AddToRepository(_view.CurrentElement, arg);
            _view.DeleteButtonClick += DeleteFromRepository;
            _view.UseFilter += (sort, filter) => UseFilter(filter, sort);
            _view.OpenFile += OpenFile;
            _view.SaveFile += SaveFile;
        }

        public void Run()
        {
            _view.Show();
        }

        public void AddToRepository(string elem, Mode mode)
        {
            try
            {
                IsNullOrEmpty(elem);
                _elemRepository.Add(elem);
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

        private void IsNullOrEmpty(string elem)
        {
            if (string.IsNullOrEmpty(elem)) throw new Exception("Element not selected");
        }
    }
}
