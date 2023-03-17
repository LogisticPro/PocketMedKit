using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db_Models
{
    public class PocketMedicine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PocketId { get; set; }

        [Required]
        public int MedicineId { get; set; }

        [Required]
        public int MedicineCount { get; set; }

        public double? Price { get; set; }
    }
}