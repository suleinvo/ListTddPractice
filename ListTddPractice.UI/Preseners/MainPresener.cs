using ListTddPractice.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListTddPractice.UI.Preseners;
using ListTddPractice.UI.Models;
using ListTddPractice.UI.Other;

namespace ListTddPractice.UI.Presenters
{
    public class MainPresenter : IPresenter
    {
        private IMainView _view;
        private IElemRepository _elemRepository;
        private IFileService _fileService;

        public MainPresenter(IMainView view, IElemRepository reposiory, IFileService _fileService)
        {
            _view = view;
            _elemRepository = reposiory;
            _view.AddWithButtonClick += (arg) => AddToRepository(_view.CurrentElement, arg);
            _view.DeleteButtonClick += (arg) => DeleteFromRepository(arg);
            _view.UseFilter += (sort, filter) => UseFilter(filter, sort);
            _view.OpenFile += (name) => OpenFile(name);
            _view.SaveFile += (name) => SaveFile(name);
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
            _view.CurrentList = _elemRepository.Get(filter: filter);
        }

        public void OpenFile(string filename)
        {
            _view.CurrentList = _fileService.ReadFile(filename); 
        }

        public void SaveFile(string filename)
        {
            _fileService.WriteFile(_view.CurrentList, filename);
        }

        private void IsNullOrEmpty(string elem)
        {
            if (string.IsNullOrEmpty(elem)) throw new Exception("Element not selected");
        }
    }
}
