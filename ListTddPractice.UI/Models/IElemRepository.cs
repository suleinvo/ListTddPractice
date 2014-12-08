namespace ListTddPractice.UI.Models
{
    public interface IElemRepository
    {
        void Add(string elem);
        void Delete(string elem);
        void Clear();
        string[] Get(string filter = null, string sorted = null);
    }
}
