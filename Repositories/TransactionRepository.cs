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
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DataContext _context;

        public TransactionRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Transaction> GetAllTransactions(int userId) 
        { 
            return _context.Transactions.Where(t => t.User.Id == userId).ToList();
        }

        public Transaction GetTransactionById(int userId, int id)
        {
            return _context.Transactions.Where(t => t.User.Id == userId && t.Id == id).FirstOrDefault();
        }

        public bool Create(Transaction transaction)
        {
            _context.Transactions.Add(transaction);

            return Save();
        }

        public bool Update(Transaction transaction)
        {
            var oldTransaction = _context.Transactions.Where(t => t.Id == transaction.Id).FirstOrDefault();

            oldTransaction.Type = transaction.Type;
            oldTransaction.CategoryName = transaction.CategoryName;
            oldTransaction.Date = transaction.Date;
            oldTransaction.Amount = transaction.Amount;
            oldTransaction.Comment = transaction.Comment;
            oldTransaction.UserId = transaction.UserId;

            return Save();
        }

        public bool Delete(int userId, int id)
        {
            var transaction = _context.Transactions.Where(t => t.User.Id == userId && t.Id == id).FirstOrDefault();

            _context.Transactions.Remove(transaction);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}
