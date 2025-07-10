using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_бухгалтерия.Models
{
    public class User
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? PasswordHash { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}
