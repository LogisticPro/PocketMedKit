using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db_Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PocketId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual Pocket Pocket { get; set; }
    }
}