using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetAllCategories(int userId);
        Category GetCategoryById(int id);
        bool Create(Category category);
        bool Update(Category category);
        bool Delete(int id);
        bool Save();
    }
}
