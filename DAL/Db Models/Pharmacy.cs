using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db_Models
{
    public class Pharmacy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PocketId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}