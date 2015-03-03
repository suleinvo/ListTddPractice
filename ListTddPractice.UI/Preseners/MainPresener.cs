using System;
using System.Collections;
using System.IO;
using System.Linq;
using ListTddPractice.UI.Models;
using ListTddPractice.UI.Other;
using ListTddPractice.UI.Views;

namespace ListTddPractice.UI.Preseners
{
    public class MainPresenter : IPresenter
    {
        private readonly IMainView _view;
        private IElemRepository _elemRepository;
        private readonly IFileService _fileService;
        private Mode _mode;
        private string _sort = null;

        public MainPresenter(IMainView view, IElemRepository reposiory, IFileService fileService)
        {
            _elemRepository = reposiory;
            _fileService = fileService;
            _view = view;
            _view.AddWithButtonClick += AddToRepository;
            _view.DeleteButtonClick += DeleteFromRepository;
            _view.SortChanged += UseSort;
            _view.OpenFile += OpenFile;
            _view.SaveFile += SaveFile;
            _view.Clear += Clear;
            _view.ModeChanged += (t => { });
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
                _view.CurrentList.Add(RepositoryHelper.Validate(elem, _mode));
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
                _view.CurrentList.Remove(elem);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void UseSort(string sort)
        {
            var list = _view.CurrentList.Cast<string>();
            if (_view.Mode == Mode.Alpha)
                _view.CurrentList.Cast<string>().Select(t=>int.Parse(t)).OrderBy(t => t);
        }

        public void OpenFile(Stream stream)
        {
            _view.CurrentList = new ArrayList();
            Mode fileMode;
            var list = _fileService.ReadFile(stream, out fileMode);
            _elemRepository = new ElemRepository(list);
            _view.CurrentList = list;
            _view.Mode = fileMode;
        }

        public void SaveFile(Stream stream)
        { 
            _fileService.WriteFile(_view.CurrentList, stream);
        }

        public void Clear()
        {
            _view.CurrentList.Clear();
            _elemRepository.Clear();
        }

        public void ModeChanged(Mode mode)
        {
           
        }

        private void IsNullOrEmpty(string elem)
        {
            if (string.IsNullOrEmpty(elem)) throw new Exception("Element not selected");
        }
    }
}
