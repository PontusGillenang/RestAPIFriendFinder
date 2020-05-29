using System.Threading.Tasks;

namespace FriendFinderAPI.Services
{
    public interface IRespository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
    }
}