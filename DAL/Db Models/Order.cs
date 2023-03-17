using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db_Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int PharmacyId { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Description { get; set; }

        public virtual User User { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}