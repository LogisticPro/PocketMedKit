using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db_Models
{
    public class Pocket
    {
        [Key]
        public int Id { get; set; }

        public virtual User User { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
    }
}