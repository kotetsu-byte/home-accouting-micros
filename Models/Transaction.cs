using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_бухгалтерия.Models
{
    public class Transaction
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        [Required]
        public DateOnly? Date { get; set; }
        [Required]
        public double? Amount { get; set; }
        public string? Comment { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
