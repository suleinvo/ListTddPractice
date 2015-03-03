using System;
using System.Collections;
using ListTddPractice.UI.Constants;
using System.Linq;
using NUnit.Framework;
using ListTddPractice.UI.Models;

namespace ListTddPractice.Tests
{
    [TestFixture]
    public class ElemRepositoryTests
    {
        private IList _resource;
        private ElemRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _resource = new ArrayList { "elem", "abracadabra", "ninja" , "123"};
            _repository = new ElemRepository(_resource); 
        }

        [TearDown]
        public void TearDown()
        {
            _resource = null;
            _repository = null;
        }


        [Test]
        public void ElemRepositotyInit_WithNullResource_Throw()
        {
            Assert.Throws<ArgumentException>(() => new ElemRepository(null));
        }

        [Test]
        public void Add_WithNull_Throw()
        {
            Assert.Throws<ArgumentException>(() => new ElemRepository().Add(null));
        }

        [Test]
        public void Add_WithCorrectElem_Succesfull()
        {
            const string addedElem = "new";
            _repository.Add(addedElem);
            Assert.True(_resource.Contains(addedElem));
        }

        [Test]
        public void Delete_WithNullArg_Throw()
        {
            Assert.Throws<ArgumentException>(() => new ElemRepository().Add(null));
        }

        [Test]
        public void Delete_WithNotExistsElem_DoNothing()
        {
            _repository.Delete("Not exists");
            CollectionAssert.AreEquivalent(_resource, _repository.Get());
        }

        [Test]
        public void Delete_WithCorrectElem_Succesfull()
        {
            const string deleteElem = "elem";
            _repository.Delete(deleteElem);
            Assert.IsFalse(_resource.Contains(deleteElem));
        }

        [Test]
        public void Get_WithoutFilters_Succesfull()
        {
            CollectionAssert.AreEquivalent(_resource, _repository.Get());
        }

        [Test]
        public void Get_WithSortAsc_Succesfull()
        {
            var sortAsc = _repository.Get(null, Sorting.Asc);
            CollectionAssert.AreEqual(new[] {"123", "abracadabra", "elem", "ninja"}, sortAsc);
        }

        [Test]
        public void Get_WithSortDesc_Succesfull()
        {
            var sortDesc = _repository.Get(null, Sorting.Desc);
            CollectionAssert.AreEqual(new[] { "ninja", "elem","abracadabra","123" }, sortDesc);
        }

        [Test]
        public void Get_WithAllFilter_Succesfull()
        {
            CollectionAssert.AreEquivalent(_resource, _repository.Get());
        }

        [Test]
        public void Get_WithA_Z_Filter_Succesfull()
        {
            CollectionAssert.AreEquivalent(new[] {"abracadabra", "elem", "ninja"}, _repository.Get());
        }
        [Test]
        public void Get_With0_10000Filter_Succesfull()
        {
            CollectionAssert.AreEquivalent(new[] {"123"}, _repository.Get());
        }

    }
}
