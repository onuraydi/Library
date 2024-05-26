using Library.Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Entities.Concrete
{
    public class Book : IEntity
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }
        public string Notes { get; set; }
        public int StatusID { get; set; }
    }
}
