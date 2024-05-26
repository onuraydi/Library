using Library.Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Entities.Concrete
{
    public class Magazine:IEntity
    {
        public int MagazineID { get; set; }
        public string MagazineName { get; set; }
        public string MagazineCategory { get; set; }
        public string Issue { get; set; }   //sayı (tarih)
        public int NumberOfPages { get; set; }
        public string Notes { get; set; }
    }
}
