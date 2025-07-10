using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetAllUsers();
        User GetUserById(int id);
        int? UserExists(string username, string password);
        bool Create(User user);
        bool Update(User user);
        bool Delete(int id);
        bool Save();
    }
}
