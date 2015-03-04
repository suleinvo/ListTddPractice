using System;
using System.Collections;
using System.Drawing.Text;
using System.IO;
using ListTddPractice.UI.Constants;
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

        private IList _fileBuffer;

        private Mode _mode;

        public MainPresenter(IMainView view, IElemRepository reposiory, IFileService fileService)
        {
            _elemRepository = reposiory;
            _fileService = fileService;
            _view = view;
            _view.AddWithButtonClick += AddToRepository;
            _view.DeleteButtonClick += DeleteFromRepository;
            _view.SortChanged += UseSearch;
            _view.OpenFile += OpenFile;
            _view.SaveFile += SaveFile;
            _view.Clear += Clear;
            _view.ModeChanged += ModeChanged;
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
                LoadState();
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
                LoadState();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public void UseSearch(string search)
        {

        }

        public void OpenFile(Stream stream)
        {
            _fileBuffer = _fileService.ReadFile(stream, out _mode);
            _view.Mode = _mode;
        }

        public void SaveFile(Stream stream)
        {
            _fileService.WriteFile(_view.CurrentList, stream);
        }

        public void Clear()
        {
            _elemRepository.Clear();
            LoadState();
        }

        public void ModeChanged(Mode mode)
        {
            _mode = mode;
            _elemRepository = new ElemRepository(GetData());
            LoadState();
        }

        private void IsNullOrEmpty(string elem)
        {
            if (string.IsNullOrEmpty(elem)) throw new Exception("Element not selected");
        }

        private void LoadState()
        {
            _view.Mode = _mode;
            _view.CurrentList = _elemRepository.Get();
        }

        private IList GetData()
        {
            if (_fileBuffer != null)
            {
                var value = _fileBuffer;
                _fileBuffer = null;
                return value;
            }
            else return _view.CurrentList;
        }

#if DEBUG
        public void SetModeForTest(Mode mode)
        {
            _mode = mode;
        }
#endif
    }
}
