using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Домашняя_бухгалтерия.Data;
using Домашняя_бухгалтерия.Interfaces;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id) 
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public int? UserExists(string username, string password)
        {
            var user = _context.Users.Where(u => u.Username == username).FirstOrDefault();
            if(user == null) { return 0; }
            var passwordIsValid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

            if (!passwordIsValid)
                return 0;

            return user.Id;
        }

        public bool Create(User user)
        {
            try
            {
                _context.Users.Add(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
            

            return Save();
        }

        public bool Update(User user)
        {
            var oldUser = _context.Users.Where(u => u.Id == user.Id).FirstOrDefault();

            oldUser.Name = user.Name;
            oldUser.Username = user.Username;
            oldUser.PasswordHash = user.PasswordHash;

            return Save();
        }

        public bool Delete(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();

            _context.Users.Remove(user);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}
