using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Домашняя_бухгалтерия.Data;
using Домашняя_бухгалтерия.Interfaces;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Category> GetAllCategories(int userId)
        {
            return _context.Categories.Where(c => c.UserId == null || c.UserId == userId).ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<string> GetSeparateCategories(int userId, string type)
        {
            var categories = GetAllCategories(userId);

            return categories.Where(c => c.Type == type).Select(c => c.Name).ToList();
        }

        public bool Create(Category category)
        {
            _context.Categories.Add(category);

            return Save();
        }

        public bool Update(Category category)
        {
            var oldCategory = _context.Categories.Where(c => c.Id == category.Id).FirstOrDefault();

            oldCategory.Type = category.Type;
            oldCategory.Name = category.Name;
            oldCategory.UserId = category.UserId;

            return Save();
        }

        public bool Delete(int id)
        {
            var category = _context.Categories.Where(c =>c.Id == id).FirstOrDefault();

            _context.Categories.Remove(category);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}
