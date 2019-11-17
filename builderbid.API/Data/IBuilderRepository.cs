using System.Collections.Generic;
using System.Threading.Tasks;
using builderbid.API.Models;

namespace builderbid.API.Data
{
    public interface IBuilderRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}