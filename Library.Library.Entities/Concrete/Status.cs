using Library.Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Entities.Concrete
{
    public class Status : IEntity
    {
        // Bu kısım Veri tabanı ilişkilendirmesi için mi eklendi????
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
