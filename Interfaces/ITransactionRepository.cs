using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Домашняя_бухгалтерия.Models;

namespace Домашняя_бухгалтерия.Interfaces
{
    public interface ITransactionRepository
    {
        ICollection<Transaction> GetAllTransactions(int userId);
        Transaction GetTransactionById(int userId, int id);
        bool Create(Transaction transaction);
        bool Update(Transaction transaction);
        bool Delete(int userId, int id);
        bool Save();
    }
}
