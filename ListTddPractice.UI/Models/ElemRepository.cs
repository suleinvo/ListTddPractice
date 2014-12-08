using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ListTddPractice.UI.Constants;

namespace ListTddPractice.UI.Models
{
    public class ElemRepository : IElemRepository
    {
        private readonly IList _memoryDb;

        public ElemRepository()
        {
            _memoryDb = new ArrayList();
        }

        public ElemRepository(IList list)
        {
            if (list == null) throw new ArgumentException("Error resource is null");
            _memoryDb = list;
        }

        public void Add(string elem)
        {
            if (elem == null) throw new ArgumentException("Error, elem can't be null");
            _memoryDb.Add(elem);
        }

        public void Delete(string elem)
        {
            if (elem == null) throw new ArgumentException("Error, elem can't be null");
            _memoryDb.Remove(elem);
        }

        public string[] Get(string filter=null, string sort=null)
        {
            var result = new List<string>();
            if (String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(sort)) return _memoryDb.Cast<string>().ToArray();
            switch (filter)
            {
                case Filter.A_z:
                    result.AddRange((from elem in _memoryDb.Cast<string>()
                                    from ch in elem.Where(Char.IsLetter) 
                                    select elem).Distinct());
                    break;
                case Filter.z0_10000:
                    result.AddRange((from elem in _memoryDb.Cast<string>()
                                    from ch in elem.Where(Char.IsDigit)
                                    select elem).Distinct());
                    break;
                case Filter.None:
                    result.AddRange(result.ToArray());
                    break;
                default :
                    result.AddRange(_memoryDb.Cast<string>().ToArray());
                    break;
            }
            if (sort == Sorting.Asc) return result.OrderBy(t => t).ToArray();
            if (sort == Sorting.Desc) return result.OrderByDescending(t => t).ToArray();
            return result.ToArray();
        }

        public void Clear()
        {
            _memoryDb.Clear();
        }
    }
}
